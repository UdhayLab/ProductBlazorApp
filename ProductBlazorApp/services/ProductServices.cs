using ProductBlazorApp.Model;
using System.Net.Http.Json;

namespace ProductBlazorApp.services
{
    public class ProductServices : IProductServices
    {
        private readonly HttpClient _httpClient;
        public ProductServices(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/product");
        }
        public async Task<Product> GetProduct(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"api/product/{id}");
        }

        public async Task<Product> AddProduct(Product product)
        {
            var response = await _httpClient.PostAsJsonAsync<Product>("api/product", product);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Product>();
            }
            else
            {
                throw new Exception("Error in Adding the product");
            }
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var response = await _httpClient.PutAsJsonAsync("api/product", product);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Product>();
            }
            else
            {
                throw new Exception("Error in updating the value");
            }
        }


        public async Task DeleteProduct(int id)
        {
            await _httpClient.DeleteAsync($"api/product/{id}");
        }
    }
}
