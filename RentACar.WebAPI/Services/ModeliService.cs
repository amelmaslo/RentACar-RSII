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
    public class ModeliService : BaseCRUDService<Model.Modeli, ModeliSearchRequest, Database.Modeli, ModeliUpsertRequest, ModeliUpsertRequest>
    {
        public ModeliService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Modeli> Get(ModeliSearchRequest search)
        {
            var query = _context.Modeli.Include(x => x.Proizvodjac).AsQueryable();

            if (search.ProizvodjacId != 0 && search.ProizvodjacId.HasValue)
            {
                query = query.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }
           
            var list = query.OrderBy(x=>x.Proizvodjac.Naziv).ToList();
            return _mapper.Map<List<Model.Modeli>>(list);
        }
    }
}
