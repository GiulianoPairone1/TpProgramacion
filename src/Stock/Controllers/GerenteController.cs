using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        private readonly IGerenteService _gerenteService;

        public GerenteController(IGerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpGet("nombre/{nombre}")]
        public IActionResult GetByName([FromRoute] string nombre)
        {
            return Ok(_gerenteService.Get(nombre));
        }
    }
}
