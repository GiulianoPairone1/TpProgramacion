using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorService _vendedorService;

        public VendedorController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }


        [HttpGet("nombre/{nombre}")]
        public IActionResult GetByName([FromRoute] string nombre) 
        {
            return Ok(_vendedorService.Get(nombre));    
        }

    }
}
