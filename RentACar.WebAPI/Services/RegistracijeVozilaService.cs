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
    public class RegistracijeVozilaService : BaseCRUDService<Model.RegistracijeVozila, RegistracijeVozilaSearchRequest, RegistracijeVozila, RegistracijeVozilaUpsertRequest, RegistracijeVozilaUpsertRequest>
    {
        public RegistracijeVozilaService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.RegistracijeVozila> Get(RegistracijeVozilaSearchRequest search)
        {
            var query = _context.RegistracijeVozila.Include("Vozilo.Model").Include(x => x.Uposlenik).AsQueryable();

            if (search.VoziloId != 0 && search.VoziloId.HasValue)
            {
                query = query.Where(x => x.VoziloId == search.VoziloId);
            }
            if (search.UposlenikId != 0 && search.UposlenikId.HasValue)
            {
                query = query.Where(x => x.UposlenikId == search.UposlenikId);
            }
            if (!string.IsNullOrWhiteSpace(search?.RegistarskeOznake))
            {
                query = query.Where(x => x.RegistarskeOznake.StartsWith(search.RegistarskeOznake));
            }
            var list = query.OrderBy(x=>x.Uposlenik).ToList();
            return _mapper.Map<List<Model.RegistracijeVozila>>(list);
        }


    }
}
