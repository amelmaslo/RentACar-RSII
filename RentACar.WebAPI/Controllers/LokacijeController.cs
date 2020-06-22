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
    public class LokacijeController : BaseCRUDController<Model.Lokacije, LokacijeSearchRequest, LokacijeUpsertRequest, LokacijeUpsertRequest>
    {
        public LokacijeController(ICRUDService<Lokacije, LokacijeSearchRequest, LokacijeUpsertRequest, LokacijeUpsertRequest> service) : base(service)
        {
        }
    }
}