using Microsoft.AspNetCore.Components;

namespace ProductBlazorApp.Components.Pages
{
    public class DeleteConfirmBase : ComponentBase
    {

        protected bool showConfirmation { get; set; }

        public void show()
        {
            showConfirmation = true;
            StateHasChanged();
        }

        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        protected async Task OnConfirmationChange(bool value)
        {
            showConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
