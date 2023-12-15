using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Record
{
    public class RecordRepository : IRecordRepository
    {
        protected readonly ManagmentContext context;

        protected readonly DbSet<RecordEntity> dbSet;
        public RecordRepository(ManagmentContext context)
        {
            this.context = context;
            dbSet = context.Set<RecordEntity>();
        }
        public async Task<IEnumerable<RecordEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet
                .Include(recored => recored.RecordKeys)
                .OrderByDescending(record => record.Time)
                .Take(100)
                .AsNoTracking()
                .ToListAsync(token);
        }
        public async Task<RecordEntity> CreateAsync(RecordEntity entity, CancellationToken token)
        {
            entity.Time = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Europe/Minsk");

            await dbSet.AddAsync(entity, token);

            await context.SaveChangesAsync(token);

            return entity;
        }

        public Task<RecordEntity?> GetByIdAsync(int id, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RecordEntity>> GetByFilter(string keyName, string keyValue, CancellationToken token)
        {
            List<RecordEntity> records = await dbSet
                .Include(record => record.RecordKeys)
                .Where(record => record.RecordKeys.FirstOrDefault(recordKey => recordKey.Name == keyName && recordKey.Value.Contains(keyValue)) != null)
                .ToListAsync(token);
            return records;
        }

        public async Task<RecordEntity> UpdateAsync(RecordEntity entity, CancellationToken token)
        {
            dbSet.Update(entity);

            await context.SaveChangesAsync(token);

            return entity;
        }

        public async Task DeleteAsync(RecordEntity entity, CancellationToken token)
        {
            dbSet.Remove(entity);

            await context.SaveChangesAsync(token);
        }
    }
}
