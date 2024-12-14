using Microsoft.AspNetCore.Mvc;
using MyProject.Services;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoadController : ControllerBase
    {
        private readonly RoadService _service;

        public RoadController(RoadService service)
        {
            _service = service;
        }

        [HttpGet("roads-to-avoid")]
        public async Task<IActionResult> GetRoadsToAvoid()
        {
            var result = await _service.GetRoadsToAvoidAsync();
            return Ok(result);
        }
    }
}
