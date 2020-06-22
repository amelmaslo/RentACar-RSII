using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentACar.Model.Requests;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using RentACar.WebAPI.Exceptions;

namespace RentACar.WebAPI.Services
{
    public class RezervacijeService : BaseCRUDService<Model.Rezervacije, RezervacijeSearchRequest, Database.Rezervacije, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijeService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Rezervacije> Get(RezervacijeSearchRequest search)
        {
            var query = _context.Rezervacije.Include("Vozilo.Model").Include(x => x.Kupac).Include(x => x.Vozilo.KategorijaVozila).Include(x => x.Osiguranje).Include(x => x.LokacijaPovrata).Include(x => x.LokacijaPreuzimanja).Include("DodatnaOprema.Oprema").AsQueryable();

            if (search.LokacijaPreuzimanjaId != 0 && search.LokacijaPreuzimanjaId.HasValue)
            {
                query = query.Where(x => x.LokacijaPreuzimanjaId == search.LokacijaPreuzimanjaId);
            }
            if (search.LokacijaPovrataId != 0 && search.LokacijaPovrataId.HasValue)
            {
                query = query.Where(x => x.LokacijaPovrataId == search.LokacijaPovrataId);
            }
            if (!string.IsNullOrWhiteSpace(search?.Vozilo))
            {
                query = query.Where(x => x.Vozilo.Model.Naziv.StartsWith(search.Vozilo));
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.Kupac.KorisnickoIme.Equals(search.KorisnickoIme));
            }

            var list = query.OrderByDescending(x=>x.DatumKreiranjaRezervacij).ToList();

            return _mapper.Map<List<Model.Rezervacije>>(list);
        }

        public override Model.Rezervacije GetById(int id)
        {
            var entity = _context.Rezervacije.Include("DodatnaOprema.Oprema").Include(x => x.Kupac).Include("Vozilo.Model").Include(x => x.Osiguranje).Where(x => x.RezervacijaId == id).FirstOrDefault();
            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public override Model.Rezervacije Insert(RezervacijeUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Rezervacije>(request);
            _context.Rezervacije.Add(entity);
            _context.SaveChanges();

            foreach (var oprema in request.Oprema)
            {
                if (oprema != 0)
                {
                    Database.DodatnaOprema dodatnaOprema = new Database.DodatnaOprema
                    {
                        RezervacijaId = entity.RezervacijaId,
                        OpremaId = oprema,
                        Datum = DateTime.Now
                    };
                    _context.DodatnaOprema.Add(dodatnaOprema);
                }
            }
            _context.SaveChanges();
            //-------------------------------
            GenerisiRacun(entity.RezervacijaId);
            //-------------------------------
            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public override Model.Rezervacije Update(int id, RezervacijeUpsertRequest request)
        {
            var entity = _context.Rezervacije.Find(id);
            _context.Rezervacije.Attach(entity);
            _context.Rezervacije.Update(entity);
            //------------------------------------------
            var listDodatnaOprema = _context.DodatnaOprema.Where(x => x.RezervacijaId == id).ToList();

            foreach (var item in listDodatnaOprema)
            {
                _context.DodatnaOprema.Remove(item);
            }
            _context.SaveChanges();


            foreach (var oprema in request.Oprema)
            {
                if (oprema != 0)
                {

                    Database.DodatnaOprema dodatnaOprema = new Database.DodatnaOprema
                    {
                        RezervacijaId = entity.RezervacijaId,
                        OpremaId = oprema,
                        Datum = DateTime.Now
                    };
                    _context.DodatnaOprema.Add(dodatnaOprema);
                }
            }
            _context.SaveChanges();
            //------------------------------------------    
            _mapper.Map(request, entity);
            _context.SaveChanges();
            //------------------------------------------    
            var racun = _context.Racuni.Where(x => x.RezervacijaId == entity.RezervacijaId && x.Status == true).FirstOrDefault();
            if (racun != null)
            {
                racun.Status = false;
                //_context.Racuni.Remove(racun);
                _context.SaveChanges();
            }

            if (entity.Status)//ako je rezervacija aktivna napravi racun, ako nije samo prethodni obori na false
            {
                GenerisiRacun(entity.RezervacijaId);
            }
            //------------------------------------------racuni

            return _mapper.Map<Model.Rezervacije>(entity);
        }


        public void GenerisiRacun(int RezervacijaId)
        {
                var rezervacija = _context.Rezervacije.Include("DodatnaOprema.Oprema").Include("Vozilo").Include(x => x.Osiguranje).Include(x => x.Kupac).Where(x => x.RezervacijaId == RezervacijaId).FirstOrDefault();
                int totalDays = (int)(rezervacija.DatumPovrata.Date - rezervacija.DatumPreuzimanja.Date).TotalDays;
                var opremaUkupno = (decimal)0;
                foreach (var oprema in rezervacija.DodatnaOprema)
                {
                    opremaUkupno += oprema.Oprema.Cijena;
                }
                var ukupno = (rezervacija.Vozilo.Cijena + rezervacija.Osiguranje.Cijena + opremaUkupno) * totalDays;
                var popust = (rezervacija.Popust / 100) ?? 0;
                popust *= ukupno;
                var PDV = ukupno * (decimal)0.17;

                Guid g = Guid.NewGuid();
                string GuidString = Convert.ToBase64String(g.ToByteArray());
                GuidString = GuidString.Replace("=", "");
                GuidString = GuidString.Replace("+", "");
                GuidString = GuidString.Replace("/", "");

                var racun = new Database.Racuni
                {
                    BrojRacuna = GuidString,
                    RezervacijaId = rezervacija.RezervacijaId,
                    Datum = DateTime.Now,
                    Popust = rezervacija.Popust,
                    Pdv = PDV,
                    IznajmljivanjeVozila = rezervacija.Vozilo.Cijena * totalDays,
                    OsiguranjeUkupno = rezervacija.Osiguranje.Cijena * totalDays,
                    OpremaUkupno = opremaUkupno * totalDays,
                    IznosBezPdv = ukupno - popust,
                    IznosSaPdv = ukupno - popust + PDV,
                    BrojDana = totalDays,
                    Status = true
                };

                string number = $"Broj racuna: {racun.BrojRacuna}\n\nIme i prezime: {rezervacija.Kupac.Ime}  {rezervacija.Kupac.Prezime} ({rezervacija.Kupac.KorisnickoIme})\n\nOd: {rezervacija.DatumPreuzimanja.ToString("dd.MM.yyyy")}\nDo: {rezervacija.DatumPovrata.ToString("dd.MM.yyyy")}\n\nVozilo:           {racun.IznajmljivanjeVozila}€\nOsiguranje:   {racun.OsiguranjeUkupno}€\nOprema:        {racun.OpremaUkupno}€\nSuma:            {ukupno}€\n\nPopust: {Decimal.Round(popust, 2)}€ ({Decimal.Round(racun.Popust ?? 0)}%)\nPDV:      {Decimal.Round(racun.Pdv, 2)}€ (17%)\n\nUkupno(bez PDV): {Decimal.Round(racun.IznosBezPdv, 2)}€ \nUkupno:                   {Decimal.Round(racun.IznosSaPdv, 2)}€";

                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(number, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);

                Bitmap qrCodeImage = code.GetGraphic(10);
                var bitmapBytes = BitmapToBytes(qrCodeImage);
                racun.QRCode = bitmapBytes;
               
                _context.Racuni.Add(racun);
                _context.SaveChanges();
        }

        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}

