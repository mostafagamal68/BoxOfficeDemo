using Blazored.LocalStorage;
using BoxOfficeDemo.Client;
using BoxOfficeDemo.Client.Services;
using BoxOfficeDemo.Client.Services.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7227/api/") }.EnableIntercept(sp));
//builder.HostEnvironment.BaseAddress
builder.Services.AddScoped<IMoviesService,MoviesService>();
builder.Services.AddScoped<IReviewsService,ReviewsService>();
builder.Services.AddScoped<IWatchListService, WatchListService>();
builder.Services.AddScoped<NotifyService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<RefreshTokenService>();
builder.Services.AddScoped<HttpInterceptorService>();
await builder.Build().RunAsync();
