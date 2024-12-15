using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class DataDisplayController : ControllerBase
{
    private readonly DataDisplayService _service;

    public DataDisplayController(DataDisplayService service)
    {
        _service = service;
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAllDatabaseData()
    {
        var data = await _service.GetAllDatabaseDataAsync();
        return Ok(data);
    }
}
