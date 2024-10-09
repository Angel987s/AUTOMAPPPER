using AutoMapper;
using AUTOMAPPPER;
using AUTOMAPPPER.Properties;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMapper _mapper;

    public ProductController(IMapper mapper)
    {
        _mapper = mapper;
    }



    [HttpGet("{id}")]
    public ActionResult<ProductDto> ObtenerProducto(int id)
    {
        // Simular la obtención de un producto (en una aplicación real, obtener de la base de datos)
        var producto = new ProductDto { Id = id, Nombre = "Laptop", Precio = 999.99m };

        // Mapear a ProductoDto
        var productoDto = _mapper.Map<ProductDto>(producto);

        return Ok(productoDto);
    }

}