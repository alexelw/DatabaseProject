using Microsoft.AspNetCore.Mvc;
using MyProject.Services;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusStopController : ControllerBase
    {
        private readonly BusStopService _service;

        public BusStopController(BusStopService service)
        {
            _service = service;
        }

        [HttpGet("best-bus-stops")]
        public async Task<IActionResult> GetBestBusStops()
        {
            var result = await _service.GetBestBusStopsAsync();
            return Ok(result);
        }
    }
}
