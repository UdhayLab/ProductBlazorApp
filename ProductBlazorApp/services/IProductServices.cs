using System.Reflection;
using ProductBlazorApp.Model;

namespace ProductBlazorApp.services
{
    public interface IProductServices
    {
        public Task<IEnumerable<Product>> GetProducts();
        public Task<Product> GetProduct(int id);
        public Task<Product> AddProduct(Product product);
        public Task<Product> UpdateProduct(Product product);
        public Task DeleteProduct(int id);
    }
    
}
