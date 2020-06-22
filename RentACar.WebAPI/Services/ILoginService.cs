using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Services
{
    public interface ILoginService
    {
        Model.Korisnici Authenticiraj(string username, string pass);
        Model.Korisnici AuthenticirajKupca(string username, string pass);

    }
}
