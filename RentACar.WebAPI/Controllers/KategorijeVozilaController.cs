using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Model;
using RentACar.WebAPI.Services;

namespace RentACar.WebAPI.Controllers
{
    public class KategorijeVozilaController : BaseController<Model.KategorijeVozila, object>
    {
        public KategorijeVozilaController(IService<KategorijeVozila, object> service) : base(service)
        {
        }
    }
}