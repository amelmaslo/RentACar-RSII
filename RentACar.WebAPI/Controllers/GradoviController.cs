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

    public class GradoviController : BaseCRUDController<Model.Gradovi, GradoviSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest>
    {
        public GradoviController(ICRUDService<Gradovi, GradoviSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest> service) : base(service)
        {
        }
    }
}