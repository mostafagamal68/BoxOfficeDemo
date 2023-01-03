using BoxOfficeDemo.Client.Configurations;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using BoxOfficeDemo.Shared.Configurations;
using BoxOfficeDemo.Shared.DTO.Account;
using BoxOfficeDemo.Shared.Models;
using System.Text.Json;
using System.Text;
using System.Net.Http.Json;

namespace BoxOfficeDemo.Client.Services.Auth
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationState _anonymous;

        public AuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");
            if (string.IsNullOrWhiteSpace(token))
                return _anonymous;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            var id = JwtParser.ParseClaimsFromJwt(token).Select(s => s.Value).ToArray()[1];
            //var content = JsonSerializer.Serialize(id);
            //var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var user = await _httpClient.GetFromJsonAsync<UserForLoginDto>("accounts/getuserinfo/"+ id);
            LoggedUser.FirstName = user.FirstName;
            LoggedUser.LastName = user.LastName;
            LoggedUser.Email = user.Email;
            LoggedUser.Id = user.Id;
            LoggedUser.EmailConfirmed = user.EmailConfirmed;
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType")));
        }

        public void NotifyUserAuthentication(string token)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(_anonymous);
            LoggedUser.Id = null;
            LoggedUser.FirstName = null;
            LoggedUser.LastName = null;
            LoggedUser.Email = null;
            LoggedUser.UserName = null;
            LoggedUser.EmailConfirmed = null;
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
