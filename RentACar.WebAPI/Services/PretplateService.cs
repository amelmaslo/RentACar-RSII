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
    public class PretplateService : BaseCRUDService<Model.Pretplate, PretplateSearchRequest, Database.Pretplate, PretplateUpsertRequest, PretplateUpsertRequest>
    {
        public PretplateService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Pretplate> Get(PretplateSearchRequest search)
        {
            var query = _context.Pretplate.Include(x => x.Kupac).Include(x=>x.KategorijaVozila).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.Kupac.KorisnickoIme.Equals(search.KorisnickoIme));
            }

            if (search.KategorijaVozilaId != 0 && search.KategorijaVozilaId.HasValue)
            {
                query = query.Where(x => x.KategorijaVozilaId == search.KategorijaVozilaId);
            }

            if (search.KupacId != 0 && search.KupacId.HasValue)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Pretplate>>(list);
        }
    }
}
