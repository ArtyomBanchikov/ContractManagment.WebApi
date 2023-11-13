using AutoMapper;
using ContractManagment.API.ViewModel.User;
using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ContractManagment.API.Controllers
{
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IGenericService<UserModel> _service;
        protected readonly IMapper _mapper;
        public LoginController(IUserService userService, IMapper mapper)
        {
            _service = userService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("/login")]
        public async Task<LoginUserViewModel> Login(ShortUserViewModel userVM, CancellationToken ct)
        {
            
            //UserViewModel userDB = _mapper.Map<UserViewModel>(_service.GetAllAsync(ct).Result.FirstOrDefault(u => u.Name == userVM.Name));
            //if (userDB == null || userVM.Password != userDB.Password)
            //    return Results.Unauthorized();
            
            //var claims = new List<Claim> { new(ClaimTypes.Name, userVM.Name), new(ClaimTypes.Role, userVM.Role) };
            //var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            //var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            //await HttpContext.SignInAsync(claimsPrincipal);
            //return Results.Accepted();
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, userVM.Name), new Claim(ClaimTypes.Role, "admin") };
            var jwt = new JwtSecurityToken(
                    issuer: "MyAuthServer",
                    audience: "MyAuthClient",
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysupersecret_secretkey!123")), SecurityAlgorithms.HmacSha256));
            string token = new JwtSecurityTokenHandler().WriteToken(jwt);
            LoginUserViewModel loginUser = _mapper.Map<LoginUserViewModel>(userVM);
            loginUser.Token = token;
            return loginUser;
        }

        [Authorize]
        [HttpGet("/userinfo/")]
        public async Task<LoginUserViewModel> TokenCheck(CancellationToken ct)
        {
            return new LoginUserViewModel
            {
                Name = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value,
                Role = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value
            };
        }
    }
}
