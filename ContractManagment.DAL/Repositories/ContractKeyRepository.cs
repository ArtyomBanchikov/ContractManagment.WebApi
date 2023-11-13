using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories
{
    public class ContractKeyRepository : IContractKeyRepository
    {
        protected readonly ManagmentContext context;

        protected readonly DbSet<ContractKeyEntity> dbSet;

        public ContractKeyRepository(ManagmentContext context)
        {
            this.context = context;
            dbSet = context.Set<ContractKeyEntity>();
        }

        public virtual async Task<IEnumerable<ContractKeyEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.AsNoTracking().ToListAsync(token);
        }

        public virtual async Task<ContractKeyEntity> CreateAsync(ContractKeyEntity entity, CancellationToken token)
        {
            await dbSet.AddAsync(entity, token);

            await context.SaveChangesAsync(token);

            return entity;
        }

        public virtual async Task<ContractKeyEntity> UpdateAsync(ContractKeyEntity entity, CancellationToken token)
        {
            dbSet.Update(entity);

            await context.SaveChangesAsync(token);

            return entity;
        }
    }
}
