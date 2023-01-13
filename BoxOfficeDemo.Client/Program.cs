using Blazored.LocalStorage;
using Blazored.Modal;
using BoxOfficeDemo.Client;
using BoxOfficeDemo.Client.Configurations;
using BoxOfficeDemo.Client.Services.Auth;
using BoxOfficeDemo.Client.Services.Movies;
using BoxOfficeDemo.Client.Services.Reviews;
using BoxOfficeDemo.Client.Services.Toast;
using BoxOfficeDemo.Client.Services.Watchlist;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

/*builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7227/api/") }.EnableIntercept(sp));*/
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://mostafagamal68.bsite.net/api/") }.EnableIntercept(sp));
//builder.HostEnvironment.BaseAddress
builder.Services.AddScoped<IMoviesService,MoviesService>();
builder.Services.AddScoped<IReviewsService,ReviewsService>();
builder.Services.AddScoped<IWatchListService, WatchListService>();
builder.Services.AddScoped<IToastService, ToastService>();
builder.Services.AddBlazoredLocalStorageAsSingleton();
builder.Services.AddBlazoredModal();
builder.Services.AddAuthorizationCore();
builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<CurrentSession>();
builder.Services.AddScoped<RefreshTokenService>();
builder.Services.AddScoped<HttpInterceptorService>();
await builder.Build().RunAsync();
