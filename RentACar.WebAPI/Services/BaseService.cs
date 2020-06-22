using AutoMapper;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public class BaseService<T, TSearch, TDatabase> : IService<T, TSearch> where TDatabase : class
    {
        protected readonly RentACarContext _context;
        protected readonly IMapper _mapper;
        public BaseService(RentACarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<T> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            return _mapper.Map<T>(entity);
        }
    }
}
