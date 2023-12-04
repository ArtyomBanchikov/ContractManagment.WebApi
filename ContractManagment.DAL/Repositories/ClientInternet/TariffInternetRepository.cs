using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientInternet
{
    public class TariffInternetRepository : GenericBillingInternetRepository<TariffInternetEntity>
    {
        public TariffInternetRepository(BillingInternetContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<TariffInternetEntity>> GetAllAsync(CancellationToken token)
        {
            List<TariffInternetEntity> tariffs = await dbSet.Where(t => t.IsDeleted == 0).AsNoTracking().ToListAsync(token);
            return tariffs;
        }
    }
}
