using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories
{
    public class KeyRepository : GenericManagmentRepository<KeyEntity>
    {
        public KeyRepository(ManagmentContext context) : base(context)
        {
        }
    }
}
