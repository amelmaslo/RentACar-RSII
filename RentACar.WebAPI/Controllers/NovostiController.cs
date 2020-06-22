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
    public class NovostiController : BaseCRUDController<Model.Novosti, NovostiSearchRequest, NovostiUpsertRequest, NovostiUpsertRequest>
    {
        public NovostiController(ICRUDService<Novosti, NovostiSearchRequest, NovostiUpsertRequest, NovostiUpsertRequest> service) : base(service)
        {
        }
    }
}