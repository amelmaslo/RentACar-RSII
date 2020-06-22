using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentACar.Model.Requests;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public class LokacijeService : BaseCRUDService<Model.Lokacije, LokacijeSearchRequest, Database.Lokacije, LokacijeUpsertRequest, LokacijeUpsertRequest>
    {
        public LokacijeService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Lokacije> Get(LokacijeSearchRequest search)
        {
            var query = _context.Lokacije.Include(x => x.Grad.Drzava).AsQueryable();

            if (search.GradId != 0 && search.GradId.HasValue)
            {
                query = query.Where(x => x.GradId == search.GradId);
            }

            var list = query.OrderBy(x => x.Grad.Drzava.Naziv).ToList();
            return _mapper.Map<List<Model.Lokacije>>(list);
        }
    }
}
