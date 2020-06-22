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
    public class RacuniService : BaseCRUDService<Model.Racuni, RacuniSearchRequest, Database.Racuni, RacuniUpsertRequest, RacuniUpsertRequest>
    {
        public RacuniService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Racuni> Get(RacuniSearchRequest search)
        {
            var query = _context.Racuni.Include(x => x.Rezervacija.Vozilo.Model).Include(x => x.Rezervacija.Kupac).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.Rezervacija.Kupac.KorisnickoIme.StartsWith(search.KorisnickoIme));
            }

            if (!string.IsNullOrWhiteSpace(search?.Vozilo))
            {
                query = query.Where(x => x.Rezervacija.Vozilo.Model.Naziv.StartsWith(search.Vozilo));
            }

            if (!string.IsNullOrWhiteSpace(search?.BrojRacuna))
            {
                query = query.Where(x => x.BrojRacuna.StartsWith(search.BrojRacuna));
            }

            if (search.RezervacijaId != 0 && search.RezervacijaId.HasValue)
            {
                query = query.Where(x => x.RezervacijaId == search.RezervacijaId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Racuni>>(list);
        }

        public override Model.Racuni GetById(int id)
        {
            var entity = _context.Racuni.Include(x => x.Rezervacija.Vozilo.Model).Include(x => x.Rezervacija.Kupac).Where(x=>x.RacunId == id).FirstOrDefault();

            return _mapper.Map<Model.Racuni>(entity);
        }
    }
}
