using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientDigital
{
    public class AccountTariffDigitalRepository : GenericBillingDigitalRepository<AccountTariffDigitalEntity>
    {
        public AccountTariffDigitalRepository(BillingDigitalContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<AccountTariffDigitalEntity>> GetAllAsync(CancellationToken token)
        {
            List<AccountTariffDigitalEntity> accountTariffs = await dbSet.Where(t => t.IsDeleted == 0).AsNoTracking().ToListAsync(token);
            return accountTariffs;
        }
    }
}
