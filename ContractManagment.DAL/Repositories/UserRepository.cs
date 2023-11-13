using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories
{
    public class UserRepository : GenericManagmentRepository<UserEntity>
    {
        public UserRepository(ManagmentContext context) : base(context)
        {
        }
    }
}
