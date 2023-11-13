using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Client;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.Client
{
    public class ClientRepository : GenericBillingRepository<ClientEntity>
    {
        public ClientRepository(BillingContext context) : base(context)
        {
        }
    }
}
