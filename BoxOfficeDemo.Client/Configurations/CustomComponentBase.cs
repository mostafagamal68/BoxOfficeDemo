using Blazored.LocalStorage;
using Blazored.Modal.Services;
using BoxOfficeDemo.Client.Services.Toast;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

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
        //[Inject]
        //public Theme Theme { get; set; }
        public bool IsLoading { get; set; }        
    }
}
