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
    public class VozilaService : BaseCRUDService<Model.Vozila, VozilaSearchRequest, Database.Vozila, VozilaUpsertRequest, VozilaUpsertRequest>
    {
        public VozilaService(RentACarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Vozila> Get(VozilaSearchRequest search)
        {
            var query = _context.Vozila.Include(x=>x.Model).Include(x=>x.Lokacija).Include(x=>x.KategorijaVozila).AsQueryable();

            if (search.ModelId != 0 && search.ModelId.HasValue)
            {
                query = query.Where(x => x.ModelId == search.ModelId);
            }
          
            if (search.LokacijaId != 0 && search.LokacijaId.HasValue)
            {
                query = query.Where(x => x.LokacijaId == search.LokacijaId);
            }
            
            if (search.KategorijaVozilaId != 0 && search.KategorijaVozilaId.HasValue)
            {
                query = query.Where(x => x.KategorijaVozilaId == search.KategorijaVozilaId);
            }
            
            if (!string.IsNullOrWhiteSpace(search?.BrojSasije))
            {
                query = query.Where(x => x.BrojSasije.StartsWith(search.BrojSasije));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Vozila>>(list);
        }

        public override Model.Vozila GetById(int id)
        {
            var entity = _context.Vozila.Include(x => x.Model.Proizvodjac).Include(x => x.Lokacija).Where(x => x.VoziloId == id).FirstOrDefault();

            return _mapper.Map<Model.Vozila>(entity);
        }
    }
}
