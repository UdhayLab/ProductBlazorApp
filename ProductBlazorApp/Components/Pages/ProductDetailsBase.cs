using Microsoft.AspNetCore.Components;
using ProductBlazorApp.services;
using ProductBlazorApp.Model;

namespace ProductBlazorApp.Components.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        public Model.Product ProductDetail { get; set; }  = new Model.Product();

        [Inject]
        public IProductServices ProductServices { get; set; }


        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            ProductDetail=  await ProductServices.GetProduct(int.Parse(Id));
        }

    }
}
