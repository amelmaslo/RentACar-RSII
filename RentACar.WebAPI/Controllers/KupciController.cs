using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Model;
using RentACar.Model.Requests;
using RentACar.WebAPI.Services;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;
        public KupciController(IKupciService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Kupci> Get([FromQuery]KupciSearchRequest request)
        {
            return _service.Get(request);
        }
        
        [Authorize]
        [HttpGet("{id}")]
        public Model.Kupci GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public Model.Kupci Insert(KupciUpsertRequest request)
        {
            return _service.Insert(request);
        }
        [Authorize]
        [HttpPut("{id}")]
        public Model.Kupci Update(int id, [FromBody]KupciUpsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}