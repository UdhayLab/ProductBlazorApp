using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProductBlazorApp.Model;
using ProductBlazorApp.services;

namespace ProductBlazorApp.Components.Pages
{
    public class ProductEditBase : ComponentBase
    {
        public Model.Product ProductEditDetail { get; set; } = new Model.Product();

        public EditProductModel ProductModelForEdit { get; set; } = new EditProductModel();


        [Inject]
        public IProductServices ProductServices { get; set; }
        [Inject]
        private NavigationManager Navigation { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }

        public ProductBlazorApp.Components.Pages.DeleteConfirmBase DeleteConfirmation { get; set; }


        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            ProductEditDetail = await ProductServices.GetProduct(int.Parse(Id));

            Mapper.Map(ProductEditDetail, ProductModelForEdit);
        }

        public async Task HandleValidSubmit()
        {
            StateHasChanged();
            Mapper.Map(ProductModelForEdit, ProductEditDetail);

            var result = await ProductServices.UpdateProduct(ProductEditDetail);

            if (result != null)
            {
                Navigation.NavigateTo("/");
            }
        }

        public void HandleDelete()
        {
            DeleteConfirmation.show();
        }

        protected async Task ConfirmDeleteClick(bool confirmed)
        {
            if (confirmed)
            {
                await ProductServices.DeleteProduct(int.Parse(Id));
                Navigation.NavigateTo("/Products");
            }
            Navigation.NavigateTo("/Products");
        }
    }
}
