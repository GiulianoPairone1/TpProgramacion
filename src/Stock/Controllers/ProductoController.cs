using Microsoft.AspNetCore.Mvc;
using Application.IServices;
using Domain.Entities;
using Domain.DTOs;
using Domain.ViewModels;

namespace Stock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductoViewModel producto)
        {
            var created = _productoService.Create(producto);

            if (!created)
            {
                return BadRequest("Id de producto existente");
            }

            string baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            string apiAndEndpointUrl = $"api/Producto/GetById";
            string locationUrl = $"{baseUrl}/{apiAndEndpointUrl}/{producto.Id}";

            return Created(locationUrl, producto);
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<ProductoDTO> GetById([FromRoute] Guid id)
        {
            var pro = _productoService.GetById(id);

            if (pro == null)
            {
                return NotFound();
            }
            return Ok(pro);
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<ProductoDTO>> GetAll()
        {
            return Ok(_productoService.GetList());
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] ProductoViewModel producto)
        {
            var up = _productoService.Update(producto);

            return NoContent();
        }

        [HttpDelete("Desactive/{id}")]
        public IActionResult Desactive([FromRoute] Guid id)
        {
            var desactive = _productoService.Desactive(id);
            if (!desactive)
            {
                return NotFound();
            }
            return NoContent();
        }


    }
}
