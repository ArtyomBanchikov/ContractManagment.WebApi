using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Client;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Client
{
    public class ClientRepository : GenericBillingRepository<ClientEntity>
    {
        public ClientRepository(BillingContext context) : base(context)
        {
        }
        public override async Task<ClientEntity?> GetByIdAsync(int account, CancellationToken token)
        {
            return await context.Clients.SingleOrDefaultAsync(client => client.Account == account);
        }
    }
}
