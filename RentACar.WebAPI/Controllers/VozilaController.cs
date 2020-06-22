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
    public class VozilaController : BaseCRUDController<Model.Vozila, VozilaSearchRequest, VozilaUpsertRequest, VozilaUpsertRequest>
    {
        public VozilaController(ICRUDService<Model.Vozila, VozilaSearchRequest, VozilaUpsertRequest, VozilaUpsertRequest> service) : base(service)
        {
        }
    }
}