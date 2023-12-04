using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientInternet
{
    public class AccountTariffInternetRepository : GenericBillingInternetRepository<AccountTariffInternetEntity>
    {
        public AccountTariffInternetRepository(BillingInternetContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<AccountTariffInternetEntity>> GetAllAsync(CancellationToken token)
        {
            List<AccountTariffInternetEntity> accountTariffs = await dbSet.Where(t => t.IsDeleted == 0).AsNoTracking().ToListAsync(token);
            return accountTariffs;
        }
    }
}
