using Microsoft.AspNetCore.Components;
using ProductBlazorApp.services;
using ProductBlazorApp.Model;

namespace ProductBlazorApp.Components.Pages
{
    public class ProductsBase : ComponentBase
    {
        public IEnumerable<Model.Product> productList { get; set; } 

        [Inject]
        public IProductServices productServices { get; set; }

        protected override async Task OnInitializedAsync()
        {
            productList = await productServices.GetProducts();            

            //productList = new List<Model.Product>()
            //{
            //    new Model.Product
            //    {
            //        ProductId = 1,
            //        Name = "Shirt",
            //        Description= "Full Sleeve Cotton Shirt",
            //        BrandName = "LP",
            //        CategoryId = 1,
            //        Price = 1200
            //    },
            //    new Model.Product
            //    {
            //        ProductId = 2,
            //        Name = "Shirt2",
            //        Description= "Half Sleeve Cotton Shirt",
            //        BrandName = "otto",
            //        CategoryId = 1,
            //        Price = 1000
            //    }
            //};
        }

    }
}
