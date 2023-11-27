using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientInternet
{
    public class ClientInterntRepository : GenericBillingInternetRepository<ClientInternetEntity>
    {
        public ClientInterntRepository(BillingInternetContext context) : base(context)
        {
        }
        public override async Task<ClientInternetEntity?> GetByIdAsync(int account, CancellationToken token)
        {
            return await context.ClientsInternet.SingleOrDefaultAsync(client => client.Account == account);
        }
    }
}
