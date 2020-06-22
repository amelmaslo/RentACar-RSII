using AutoMapper;
using RentACar.Model.Requests;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public class NotifikacijeService : BaseCRUDService<Model.Notifikacije, NotifikacijeSearchRequest, Database.Notifikacije, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest>
    {
        public NotifikacijeService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Notifikacije> Get(NotifikacijeSearchRequest search)
        {
            var query = _context.Notifikacije.AsQueryable();

            if (search.KupacId != 0 && search.KupacId.HasValue)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }


            if (search.NovostId != 0 && search.NovostId.HasValue)
            {
                query = query.Where(x => x.NovostId == search.NovostId);
            }


            if (search.Status.HasValue)
            {
                query = query.Where(x => x.Status == search.Status);
            }

            var list = query.OrderByDescending(x => x.DatumSlanja).ToList();
            return _mapper.Map<List<Model.Notifikacije>>(list);
        }
    }
}
