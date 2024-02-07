using BoxOfficeDemo.Client.Services;
using Microsoft.EntityFrameworkCore;
using BoxOfficeDemo.Server.Data;
using BoxOfficeDemo.Server.Configurations;
using BoxOfficeDemo.Server.Services.TokenHelpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BoxOfficeDemo.Server.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var allowedHosts = new List<string> { "localhost", "github"};
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            //policy.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
            //        .AllowAnyHeader().AllowAnyMethod();
            policy.SetIsOriginAllowed(origin => allowedHosts.Contains(new Uri(origin).Host))
                    .AllowAnyHeader().AllowAnyMethod();
            //policy.WithOrigins("https://mostafagamal68.github.io")
            //        .AllowAnyHeader().AllowAnyMethod();
        });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BoxOfficeDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BoxOfficeDemoConnection")));
builder.Services.AddIdentity<User, IdentityRole>()
  .AddEntityFrameworkStores<BoxOfficeDBContext>();
builder.Services.AddScoped<IMoviesLogic, MoviesLogic>();
builder.Services.AddScoped<IReviewsLogic, ReviewsLogic>();
builder.Services.AddScoped<IWatchListLogic, WatchListLogic>();
builder.Services.AddAutoMapper(typeof(MapperConfig));

var jwtSettings = builder.Configuration.GetSection("JWTSettings");
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["validIssuer"],
        ValidAudience = jwtSettings["validAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["securityKey"]))
    };
});

builder.Services.AddScoped<ITokenService, TokenService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
