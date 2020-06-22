using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentACar.Model.Requests;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public class PreporukeService : IPreporukeService
    {
        private readonly RentACarContext _context;
        private readonly IMapper _mapper;
        public PreporukeService(RentACarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Vozila> Get(PreporukeSearchRequest request)
        {
            var list = _context.Vozila.Include(x=>x.Model).Include(x=>x.Lokacija).Where(x => x.KategorijaVozilaId == request.KategorijaVozilaId && x.LokacijaId == request.LokacijaPreuzimanjaId && x.Status).ToList();
            var rezervacijeList = _context.Rezervacije.Where(x => x.Status == true).ToList();
            List<Database.Vozila> vozilaList = new List<Database.Vozila>();
         
            foreach (var item in list)
            {
                bool nema = true;
                foreach (var rezervacija in rezervacijeList)
                {
                    if (rezervacija.Status && rezervacija.VoziloId == item.VoziloId)
                    {
                        if (!(request.DatumPovrata.Date <= rezervacija.DatumPreuzimanja.Date || request.DatumPreuzimanja.Date >= rezervacija.DatumPovrata.Date))
                        {
                            nema = false;
                        }
                    }
                }
                if (nema)
                { //ako nije rezervisani
                    vozilaList.Add(item);
                }
            }

            var preporucenaVozilaList = new List<Database.Vozila>();
            var predhodneRezervacijeList = _context.Rezervacije.Where(x => x.Kupac.KorisnickoIme == request.KorisnickoIme).ToList();
            foreach (var item in vozilaList)
            {
                if (predhodneRezervacijeList.Where(x => x.VoziloId == item.VoziloId).Count() != 0 && preporucenaVozilaList.Count != 1)//ako ga je prethodno rezervisao && preporucena ne prelaze broj povratnih vozila
                {
                    preporucenaVozilaList.Add(item);
                }
            }
            if (preporucenaVozilaList.Count == 0 && vozilaList.Count != 0)//ako nema preporucenih vozila vratiti neko nasumicno odabrano
            {
                var prep = vozilaList.OrderBy(x => Guid.NewGuid()).ToList();
                preporucenaVozilaList.Add(prep.FirstOrDefault());
            }

            return _mapper.Map<List<Model.Vozila>>(preporucenaVozilaList);
        }
    }
}
