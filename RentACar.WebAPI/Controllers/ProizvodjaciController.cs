using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Model;
using RentACar.Model.Requests;
using RentACar.WebAPI.Services;

namespace RentACar.WebAPI.Controllers
{
    public class ProizvodjaciController : BaseCRUDController<Model.Proizvodjaci, object, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>
    {
        public ProizvodjaciController(ICRUDService<Proizvodjaci, object, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest> service) : base(service)
        {
        }
    }
}