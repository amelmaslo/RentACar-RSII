using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentACar.Model.Requests;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public class GradoviService : BaseCRUDService<Model.Gradovi, GradoviSearchRequest, Database.Gradovi, GradoviUpsertRequest, GradoviUpsertRequest>
    {
        public GradoviService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Gradovi> Get(GradoviSearchRequest search)
        {
            var query = _context.Gradovi.Include(x=>x.Drzava).AsQueryable();

            if (search.DrzavaId != 0 && search.DrzavaId.HasValue)
            {
                query = query.Where(x => x.DrzavaId == search.DrzavaId);
            }

            var list = query.OrderBy(x=>x.Drzava.Naziv).ToList();

            return _mapper.Map<List<Model.Gradovi>>(list);
        }
    }
}
