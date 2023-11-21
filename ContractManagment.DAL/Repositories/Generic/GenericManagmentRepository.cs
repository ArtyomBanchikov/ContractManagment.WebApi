using ContractManagment.DAL.EF;
using ContractManagment.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Generic
{
    public class GenericManagmentRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ManagmentContext context;

        protected readonly DbSet<TEntity> dbSet;

        public GenericManagmentRepository(ManagmentContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.ToListAsync(token);
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity, CancellationToken token)
        {
            await dbSet.AddAsync(entity, token);

            await context.SaveChangesAsync(token);

            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token)
        {
            dbSet.Update(entity);

            await context.SaveChangesAsync(token);

            return entity;
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id, CancellationToken token)
        {
            return await dbSet.FindAsync(new object[] { id }, token);
        }

        public virtual async Task DeleteAsync(TEntity entity, CancellationToken token)
        {
            dbSet.Remove(entity);

            await context.SaveChangesAsync(token);
        }
    }
}
