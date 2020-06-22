using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public interface IKupciService
    {
        List<Model.Kupci> Get(KupciSearchRequest request);
        Model.Kupci GetById(int id);
        Model.Kupci Insert(KupciUpsertRequest request);
        Model.Kupci Update(int id, KupciUpsertRequest request);
        Model.Kupci AuthenticirajKupce(string username, string pass);
    }
}
