using AutoMapper;

namespace AUTOMAPPPER.Properties
{
    public class PerfilMapeo : Profile
    {
        public PerfilMapeo() { 
        
            CreateMap<Usuario, UsuarioDto>().ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.Nombre));
        }
    }
}
