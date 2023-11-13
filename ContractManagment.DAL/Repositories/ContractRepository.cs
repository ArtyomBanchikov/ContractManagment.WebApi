using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories
{
    public  class ContractRepository : GenericManagmentRepository<ContractEntity>
    {
        public ContractRepository(ManagmentContext context) : base(context)
        {
        }
    }
}
