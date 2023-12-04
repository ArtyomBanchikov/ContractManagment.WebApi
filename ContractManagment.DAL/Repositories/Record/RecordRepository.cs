using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Record
{
    public class RecordRepository : GenericManagmentRepository<RecordEntity>
    {
        public RecordRepository(ManagmentContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<RecordEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.OrderByDescending(record => record.Time).ToListAsync();
        }
        public override async Task<RecordEntity> CreateAsync(RecordEntity entity, CancellationToken token)
        {
            entity.Time = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Europe/Minsk");
            return await base.CreateAsync(entity, token);
        }
    }
}
