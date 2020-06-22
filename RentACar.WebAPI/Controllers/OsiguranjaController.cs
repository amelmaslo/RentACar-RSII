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
    public class OsiguranjaController : BaseCRUDController<Model.Osiguranja, object, OsiguranjaUpsertRequest, OsiguranjaUpsertRequest>
    {
        public OsiguranjaController(ICRUDService<Osiguranja, object, OsiguranjaUpsertRequest, OsiguranjaUpsertRequest> service) : base(service)
        {
        }
    }
}