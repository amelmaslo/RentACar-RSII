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
    public class OpremaController : BaseCRUDController<Model.Oprema, object, OpremaUpsertRequest, OpremaUpsertRequest>
    {
        public OpremaController(ICRUDService<Oprema, object, OpremaUpsertRequest, OpremaUpsertRequest> service) : base(service)
        {
        }
    }
}