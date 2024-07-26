using AutoMapper;

namespace ProductBlazorApp.Model
{
    public class ProductMapperProfile : Profile
    {
        public ProductMapperProfile() 
        {
            CreateMap<Product,EditProductModel>();
            CreateMap<EditProductModel, Product>();
        }
    }
}
