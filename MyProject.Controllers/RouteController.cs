using MyProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RouteController : ControllerBase
    {
        private readonly RouteService _routeService;

        public RouteController(RouteService routeService)
        {
            _routeService = routeService;
        }

        [HttpGet("affected-by-roadworks")]
        public async Task<IActionResult> GetRoutesAffectedByRoadworks()
        {
            var routes = await _routeService.GetRoutesAffectedByRoadworksAsync();
            return Ok(routes);
        }
    }
}
