using AutoMapper;
using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Models;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services
{
    public class UserService : GenericService<UserModel, UserEntity>, IUserService
    {
        public UserService(IGenericRepository<UserEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
