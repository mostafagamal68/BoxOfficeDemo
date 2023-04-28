using Blazored.LocalStorage;
using Blazored.Modal.Services;
using BoxOfficeDemo.Client.Services.Auth;
using BoxOfficeDemo.Client.Services.Toast;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;

namespace BoxOfficeDemo.Client.Configurations
{
    public class CustomComponentBase : ComponentBase
    {
        [Inject]
        public ILocalStorageService localStorage { get; set; }
        [Inject]
        public IJSRuntime JS { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IModalService ModalService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public IAuthorizationService AuthorizationService { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public Sessions CurrentSession { get; set; }

        [CascadingParameter(Name = "DateFormat")]
        public string DateFormat { get; set; }

        [CascadingParameter(Name = "TimeFormat")]
        public string TimeFormat { get; set; }

        [CascadingParameter(Name = "Culture")]
        public IFormatProvider Culture { get; set; }

        [CascadingParameter]
        public Task<AuthenticationState> authenticationStateTask { get; set; }

        public bool IsLoading { get; set; }
        public void NavigateToPage(string pagename, decimal? id = null)
        {
            if (id != null)
                NavigationManager.NavigateTo($"/{pagename}/{id.ToString().Replace('.', 'O')}");
            else
                NavigationManager.NavigateTo("/" + pagename);
        }
    }
}
