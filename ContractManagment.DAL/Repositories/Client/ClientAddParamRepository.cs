using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Client;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.Client
{
    public class ClientAddParamRepository : GenericBillingRepository<ClientAddParamEntity>
    {
        public ClientAddParamRepository(BillingContext context) : base(context)
        {
        }
    }
}
