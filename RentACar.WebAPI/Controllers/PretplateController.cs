using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Model.Requests;
using RentACar.WebAPI.Services;

namespace RentACar.WebAPI.Controllers
{
    public class PretplateController : BaseCRUDController<Model.Pretplate, PretplateSearchRequest, PretplateUpsertRequest, PretplateUpsertRequest>
    {
        public PretplateController(ICRUDService<Model.Pretplate, PretplateSearchRequest, PretplateUpsertRequest, PretplateUpsertRequest> service) : base(service)
        {
        }
    }
}