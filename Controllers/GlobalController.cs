using System;
using System.Threading.Tasks;
using Echoey.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Echoey.Controllers
{
    public class GlobalController : Controller
    {
        IRoutesRepository _repository;
        public GlobalController(IRoutesRepository routesRepository)
        {
            _repository = routesRepository;
        }

        [HttpGet]
        [Route("{*url}")]
        public async Task<IActionResult> Get(string url)
        {
            var verb = "GET";
            var route = await _repository.Match("/" + url, verb);
            Console.WriteLine($"***matched route: {url},{verb}");
            Console.WriteLine($"***matched route: {route}");
            return Ok(route.Response);
        }
    }
}