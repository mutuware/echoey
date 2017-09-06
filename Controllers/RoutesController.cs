using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Echoey.Contexts;
using Echoey.Models;
using Echoey.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Echoey.Controllers
{
    [Route("_api/[controller]")]
    public class RoutesController : Controller
    {
        IRoutesRepository _repository;
        public RoutesController(IRoutesRepository routesRepository)
        {
            _repository = routesRepository;
        }

        // GET api/routes
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var routes = await _repository.GetAll();
            return Ok(routes);
        }
        // GET api/routes/5
        [HttpGet("{id}", Name = "GetRoute")]
        public async Task<IActionResult> Get(int id)
        {
            var routes = await _repository.Get(id);
            return Ok(routes);
        }


        // POST api/routes
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]EchoeyRoute route)
        {
            await _repository.Add(route);
            return CreatedAtRoute("GetRoute", new { Controller = nameof(RoutesController), Id = route.Id }, route);
        }
    }
}
