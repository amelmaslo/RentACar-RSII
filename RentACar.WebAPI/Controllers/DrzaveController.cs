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
    public class DrzaveController : BaseCRUDController<Model.Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest>
    {
        public DrzaveController(ICRUDService<Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest> service) : base(service)
        {
        }
    }
}