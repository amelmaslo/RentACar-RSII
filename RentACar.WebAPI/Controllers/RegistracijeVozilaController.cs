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
    public class RegistracijeVozilaController : BaseCRUDController<Model.RegistracijeVozila, RegistracijeVozilaSearchRequest, RegistracijeVozilaUpsertRequest, RegistracijeVozilaUpsertRequest>
    {
        public RegistracijeVozilaController(ICRUDService<RegistracijeVozila, RegistracijeVozilaSearchRequest, RegistracijeVozilaUpsertRequest, RegistracijeVozilaUpsertRequest> service) : base(service)
        {
        }
    }
}