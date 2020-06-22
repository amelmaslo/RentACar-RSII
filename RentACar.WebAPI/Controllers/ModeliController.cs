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
    public class ModeliController : BaseCRUDController<Model.Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest>
    {
        public ModeliController(ICRUDService<Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest> service) : base(service)
        {
        }
    }
}