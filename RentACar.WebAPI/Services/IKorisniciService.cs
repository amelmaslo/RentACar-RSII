using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get(KorisniciSearchRequest request);
        Model.Korisnici GetById(int id);
        Model.Korisnici Insert(KorisniciUpsertRequest request);
        Model.Korisnici Update(int id, KorisniciUpsertRequest request);
        Model.Korisnici Authenticiraj(string username, string pass);
    }
}
