using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Model.Requests;
using RentACar.WebAPI.Services;

namespace RentACar.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukeController : ControllerBase
    {
        private readonly IPreporukeService _service;
        public PreporukeController(IPreporukeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Vozila> Get([FromQuery]PreporukeSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}