using AutoMapper;
using ContractManagment.API.ViewModel.User;
using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
            UserViewModel userDB = _mapper.Map<UserViewModel>((await _service.GetAllAsync(ct)).First(u => u.Name == userVM.Name));
            IPasswordHasher hasher = new PasswordHasher();
            Microsoft.AspNet.Identity.PasswordVerificationResult result = hasher.VerifyHashedPassword(userDB.Password, userVM.Password);
            switch(result)
            {
                case Microsoft.AspNet.Identity.PasswordVerificationResult.Success:
                    {
                        var claims = new List<Claim> { new Claim(ClaimTypes.Name, userDB.Name), new Claim(ClaimTypes.Role, userDB.Role) };
                        var jwt = new JwtSecurityToken(
                                issuer: "MyAuthServer",
                                audience: "MyAuthClient",
                                claims: claims,
                                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(6)),
                                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysupersecret_secretkey!123")), SecurityAlgorithms.HmacSha256));
                        string token = new JwtSecurityTokenHandler().WriteToken(jwt);
                        LoginUserViewModel loginUser = _mapper.Map<LoginUserViewModel>(userVM);
                        loginUser.Token = token;
                        loginUser.Role = userDB.Role;
                        loginUser.FIO = userDB.FIO;
                        return loginUser;
                    }
                default:
                    throw new UnauthorizedAccessException();
            }
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
