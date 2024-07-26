using Microsoft.AspNetCore.Components;
using ProductBlazorApp.Model;
using ProductBlazorApp.services;

namespace ProductBlazorApp.Components.Pages
{
    public class ProductCreateBase : ComponentBase
    {
        public Product ProductForCreate { get; set; } = new Product();

        [Inject]
        protected IProductServices _ProductServices { get; set; }
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        public async Task HandleAddProduct()
        {
            StateHasChanged();
            var result =await _ProductServices.AddProduct(ProductForCreate);

            if (result != null)
            {
                NavigationManager.NavigateTo("/Products");
            }
        }
    }
}
