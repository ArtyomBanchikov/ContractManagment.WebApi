using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.User;
using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize(Roles ="admin")]
    public class UserController : GenericController<UserModel, UserViewModel>
    {
        public UserController(IUserService userService, IMapper mapper) : base(userService, mapper)
        {

        }
    }
}
