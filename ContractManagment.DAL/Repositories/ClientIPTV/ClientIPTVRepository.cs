using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientIPTV
{
    internal class ClientIPTVRepository : GenericBillingIPTVRepository<ClientIPTVEntity>
    {
        public ClientIPTVRepository(BillingIPTVContext context) : base(context)
        {
        }
        public override async Task<ClientIPTVEntity?> GetByIdAsync(int account, CancellationToken token)
        {
            return await context.ClientsIPTV.SingleOrDefaultAsync(client => client.Account == account);
        }
    }
}
