﻿using ContractManagment.DAL.EF;
using ContractManagment.DAL.Interfaces.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Generic
{
    public class GenericBillingIPTVRepository<TEntity> : IGenericReadRepository<TEntity> where TEntity : class
    {
        protected readonly BillingIPTVContext context;

        protected readonly DbSet<TEntity> dbSet;

        public GenericBillingIPTVRepository(BillingIPTVContext context)
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
