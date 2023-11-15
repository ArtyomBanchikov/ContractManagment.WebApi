using ContractManagment.API.Middlewares;
using ContractManagment.BLL.DI;
using Microsoft.AspNetCore.Authentication;
using Serilog;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using ContractManagment.API.ViewModel;
using Microsoft.AspNetCore.HttpOverrides;
using System.Net;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using ContractManagment.API.Controllers;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services));

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders =
        ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.RequireHeaderSymmetry = false;
    options.ForwardLimit = 5;
    options.KnownProxies.Add(IPAddress.Parse("::ffff:172.17.0.1"));
});

builder.Services.AddBllServices(builder.Configuration);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = "MyAuthServer",
            ValidateAudience = true,
            ValidAudience = "MyAuthClient",
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysupersecret_secretkey!123")),
            ValidateIssuerSigningKey = true,
        };
    });
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(options =>
//    {
//        options.LoginPath = "/login";
//        options.ExpireTimeSpan = TimeSpan.FromMilliseconds(1);
//        options.Cookie.MaxAge = options.ExpireTimeSpan;
//        options.SlidingExpiration = true;
//    });
builder.Services.AddAuthorization();

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(ContractManagment.BLL.Mappers.MappingProfile), typeof(ContractManagment.API.Mappers.MappingProfile));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();
app.UseSerilogRequestLogging();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseForwardedHeaders();
app.UseHttpsRedirection();

app.UseMiddleware<ClientLoggingMidleware>();
app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseAuthentication();
app.UseAuthorization();

/*app.MapPost("/login/{username}", (UserViewModel user, string username) =>
{
    var claims = new List<Claim> { new Claim(ClaimTypes.Name, username), new Claim(ClaimTypes.Role, user.Role) };
    var jwt = new JwtSecurityToken(
            issuer: "MyAuthServer",
            audience: "MyAuthClient",
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysupersecret_secretkey!123")), SecurityAlgorithms.HmacSha256));
    string token = new JwtSecurityTokenHandler().WriteToken(jwt);
    return token;
});*/
/*app.MapPost("/login/{username}", async (HttpContext context, string username) =>
{
    UserViewModel user = context.Request.ReadFromJsonAsync<UserViewModel>().Result;
    var claims = new List<Claim> { new(ClaimTypes.Name, username), new(ClaimTypes.Role, user.Role) };
    var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
    await context.SignInAsync(claimsPrincipal);
    return Results.Accepted;
});*/


//app.MapGet("/logout", async (HttpContext context) =>
//{
//    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
//    return "Данные удалены";
//});

app.MapControllers();

app.Run();
