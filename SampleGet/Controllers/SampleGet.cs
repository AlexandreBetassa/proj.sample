using Microsoft.AspNetCore.Mvc;

namespace SampleGet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleGet : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Ok");
        }
    }
}
