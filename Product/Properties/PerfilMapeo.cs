using AutoMapper;

namespace AUTOMAPPPER.Properties
{


    public class PerfilMapeo : Profile
    {
        public PerfilMapeo()
        {

            CreateMap<Product, ProductDto>();
        }
    }



}
