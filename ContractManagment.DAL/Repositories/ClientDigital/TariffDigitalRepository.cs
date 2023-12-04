using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.ClientDigital
{
    public class TariffDigitalRepository : GenericBillingDigitalRepository<TariffDigitalEntity>
    {
        public TariffDigitalRepository(BillingDigitalContext context) : base(context)
        {
        }
        public async override Task<IEnumerable<TariffDigitalEntity>> GetAllAsync(CancellationToken token)
        {
            List<TariffDigitalEntity> tariffs =  await dbSet.Where(t => t.IsDeleted == 0).AsNoTracking().ToListAsync(token);
            return tariffs;
        }
    }
}
