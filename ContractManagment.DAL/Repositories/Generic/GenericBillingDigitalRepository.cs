using ContractManagment.DAL.EF;
using ContractManagment.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Generic
{
    public class GenericBillingDigitalRepository<TEntity> : IGenericReadRepository<TEntity> where TEntity : class
    {
        protected readonly BillingDigitalContext context;

        protected readonly DbSet<TEntity> dbSet;

        public GenericBillingDigitalRepository(BillingDigitalContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.AsNoTracking().ToListAsync(token);
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id, CancellationToken token)
        {
            return await dbSet.FindAsync(new object[] { id }, token);
        }
    }
}
