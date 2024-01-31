using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientIPTV
{
    internal class TariffIPTVRepository : GenericBillingIPTVRepository<TariffIPTVEntity>
    {
        public TariffIPTVRepository(BillingIPTVContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<TariffIPTVEntity>> GetAllAsync(CancellationToken token)
        {
            List<TariffIPTVEntity> tariffs = await dbSet.Where(t => t.IsDeleted == 0).AsNoTracking().ToListAsync(token);
            return tariffs;
        }
    }
}
