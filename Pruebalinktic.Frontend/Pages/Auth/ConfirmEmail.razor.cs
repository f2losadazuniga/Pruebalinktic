using Blazored.Modal.Services;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Pruebalinktic.Frontend.Repositories;

namespace Pruebalinktic.Frontend.Pages.Auth
{
    public partial class ConfirmEmail
    {
        private string? message;

        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;
        [Inject] private IRepository Repository { get; set; } = null!;

        [Parameter, SupplyParameterFromQuery] public string UserId { get; set; } = string.Empty;
        [Parameter, SupplyParameterFromQuery] public string Token { get; set; } = string.Empty;
        [CascadingParameter] IModalService Modal { get; set; } = default!;

        protected async Task ConfirmAccountAsync()
        {
            var responseHttp = await Repository.GetAsync($"/api/accounts/ConfirmEmail/?userId={UserId}&token={Token}");
            if (responseHttp.Error)
            {
                message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                NavigationManager.NavigateTo("/");
                return;
            }

            await SweetAlertService.FireAsync("Confirmación", "Gracias por confirmar su email, ahora puedes ingresar al sistema.", SweetAlertIcon.Info);
            Modal.Show<Login>();
        }
    }
}
