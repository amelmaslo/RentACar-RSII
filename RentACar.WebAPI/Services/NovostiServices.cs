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
    public class NovostiServices : BaseCRUDService<Model.Novosti, NovostiSearchRequest, Database.Novosti, NovostiUpsertRequest, NovostiUpsertRequest>
    {
        public NovostiServices(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Novosti> Get(NovostiSearchRequest search)
        {
            var query = _context.Novosti.Include(x => x.Korisnik).AsQueryable();

            if (search.KorisnikId != 0 && search.KorisnikId.HasValue)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            var list = query.OrderByDescending(x=>x.Datum).ToList();

            return _mapper.Map<List<Model.Novosti>>(list);
        }
    }
}
