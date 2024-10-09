using AutoMapper;

namespace AUTOMAPPPER.Properties
{
    public class PerfilMapeo : Profile
    {
        public PerfilMapeo() { 
        
            CreateMap<Usuario, UsuarioDto>().ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.Nombre));
        }


       
    }


    public class PerfilMapeo2 : Profile
    {
        public PerfilMapeo2()
        {

            CreateMap<Product, ProductDto>();
        }



    }



}
