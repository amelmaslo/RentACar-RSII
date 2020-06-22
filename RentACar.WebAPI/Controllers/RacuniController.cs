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
    public class RacuniController : BaseCRUDController<Model.Racuni, RacuniSearchRequest, RacuniUpsertRequest, RacuniUpsertRequest>
    {
        public RacuniController(ICRUDService<Racuni, RacuniSearchRequest, RacuniUpsertRequest, RacuniUpsertRequest> service) : base(service)
        {
        }
    }
}