using Microsoft.AspNetCore.Mvc;
using OrbitalAlert.API.Services;

namespace OrbitalAlert.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NasaController : ControllerBase
    {
        private readonly NasaService _nasaService;

        public NasaController(NasaService nasaService)
        {
            _nasaService = nasaService;
        }

        [HttpGet("apod")]
        public async Task<IActionResult> GetApod()
        {
            var result = await _nasaService.GetApodAsync();

            return Ok(result);
        }
    }
}