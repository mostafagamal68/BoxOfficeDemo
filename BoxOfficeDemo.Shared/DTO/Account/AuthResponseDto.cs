namespace BoxOfficeDemo.Shared.DTO.Account
{
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool VerifiedEmail { get; set; }
        public string UserID { get; set; }
    }
}
