using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientDigital
{
    public class ClientDigitalRepository : GenericBillingDigitalRepository<ClientDigitalEntity>
    {
        public ClientDigitalRepository(BillingDigitalContext context) : base(context)
        {
        }
        public override async Task<ClientDigitalEntity?> GetByIdAsync(int account, CancellationToken token)
        {
            return await context.ClientsDigital.SingleOrDefaultAsync(client => client.Account == account);
        }
    }
}
