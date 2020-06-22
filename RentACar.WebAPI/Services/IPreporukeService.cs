using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public interface IPreporukeService
    {
        List<Model.Vozila> Get(PreporukeSearchRequest request);
    }
}
