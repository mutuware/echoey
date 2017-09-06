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

        [Route("{*url}")]
        public async Task<IActionResult> Get(string url)
        {
            var verb = HttpContext.Request.Method;
            var route = await _repository.Match(url, verb);

            if (route == null)
                return NotFound();
            else
                return Ok(route.Response);
        }
    }
}