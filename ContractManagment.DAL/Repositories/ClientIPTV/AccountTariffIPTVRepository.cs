using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientIPTV
{
    public class AccountTariffIPTVRepository : GenericBillingIPTVRepository<AccountTariffIPTVEntity>
    {
        public AccountTariffIPTVRepository(BillingIPTVContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<AccountTariffIPTVEntity>> GetAllAsync(CancellationToken token)
        {
            List<AccountTariffIPTVEntity> accountTariffs = await dbSet.Where(t => t.IsDeleted == 0).AsNoTracking().ToListAsync(token);
            return accountTariffs;
        }
    }
}
