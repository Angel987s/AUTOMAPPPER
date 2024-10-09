using AutoMapper;
using AUTOMAPPPER;
using AUTOMAPPPER.Properties;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly IMapper _mapper;

    public UsuariosController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public ActionResult<UsuarioDto> ObtenerUsuario(int id)
    {
        // Simular la obtención de un usuario (en una aplicación real, obtener de la base de datos)
        var usuario = new Usuario { Id = id, Nombre = "Juan Pérez" };

        // Mapear a UsuarioDto
        var usuarioDto = _mapper.Map<UsuarioDto>(usuario);

        return Ok(usuarioDto);
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(); // This line adds the required services for controllers
        services.AddAutoMapper(typeof(PerfilMapeo)); // Add AutoMapper services (if you're using it)
    }
}