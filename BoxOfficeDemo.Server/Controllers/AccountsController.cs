using AutoMapper;
using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Server.Services.TokenHelpers;
using BoxOfficeDemo.Shared.DTO.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace BoxOfficeDemo.Server.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    [AllowAnonymous]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _jwtSettings;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountsController(UserManager<User> userManager, IConfiguration configuration, ITokenService tokenService, IMapper mapper)
        {
            _userManager = userManager;
            _configuration = configuration;
            _tokenService = tokenService;
            _mapper = mapper;
            _jwtSettings = _configuration.GetSection("JwtSettings");
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            if (userForRegistration == null || !ModelState.IsValid)
                return BadRequest();

            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                return BadRequest(new RegistrationResponseDto { Errors = errors });
            }
            await _userManager.AddToRoleAsync(user, "User");
            return StatusCode(201);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto userForAuthentication)
        {
            var user = await _userManager.FindByEmailAsync(userForAuthentication.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, userForAuthentication.Password))
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });
            if (!await _userManager.IsEmailConfirmedAsync(user))
                return Unauthorized(new AuthResponseDto { IsAuthSuccessful = true, VerifiedEmail = false, ErrorMessage = "Email not confirmed", UserID = user.Id });

            var signingCredentials = _tokenService.GetSigningCredentials();
            var claims = await _tokenService.GetClaims(user);
            var tokenOptions = _tokenService.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            user.RefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
            await _userManager.UpdateAsync(user);
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token, RefreshToken = user.RefreshToken, VerifiedEmail = true, UserID = user.Id });
        }

        [HttpPut("VerifyEmail")]
        public async Task<IActionResult> VerifyEmail([FromBody] string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
                return NotFound(new AuthResponseDto { ErrorMessage = "User not found" });
            user.EmailConfirmed = true;
            await _userManager.UpdateAsync(user);
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, VerifiedEmail = true });
        }

        [HttpGet("GetUserInfo/{id}")]
        public async Task<IActionResult> GetUserInfo(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            return Ok(new UserForLoginDto { Id = user.Id, FirstName = user.FirstName, LastName = user.LastName, Email = user.Email, UserName = user.UserName });
        }
    }
}
