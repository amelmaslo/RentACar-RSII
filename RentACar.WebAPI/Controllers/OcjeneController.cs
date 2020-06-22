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
    public class OcjeneController : BaseCRUDController<Model.Ocjene, object, OcjeneUpsertRequest, OcjeneUpsertRequest>
    {
        public OcjeneController(ICRUDService<Ocjene, object, OcjeneUpsertRequest, OcjeneUpsertRequest> service) : base(service)
        {
        }
    }
}