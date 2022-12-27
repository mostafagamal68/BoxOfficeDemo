using BoxOfficeDemo.Shared.DTO.Account;

namespace BoxOfficeDemo.Client.Services.Auth
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);

        Task<AuthResponseDto> VerifyEmail(string id);
        Task Logout();
        Task<string> RefreshToken();
        //Task GetUserIDFromToken(string? email);
    }
}
