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
    public class NotifikacijeController : BaseCRUDController<Model.Notifikacije, NotifikacijeSearchRequest, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest>
    {
        public NotifikacijeController(ICRUDService<Notifikacije, NotifikacijeSearchRequest, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest> service) : base(service)
        {
        }
    }
}