using ContractManagment.DAL.Entities.Record;

namespace ContractManagment.DAL.Interfaces
{
    public interface IRecordRepository
    {
        Task<IEnumerable<RecordEntity>> GetAllAsync(CancellationToken token);
        Task<RecordEntity?> GetByIdAsync(int id, CancellationToken token);
        Task<IEnumerable<RecordEntity>> GetByFilter(string keyName, string keyValue, CancellationToken token);
        Task<RecordEntity> UpdateAsync(RecordEntity entity, CancellationToken token);
        Task<RecordEntity> CreateAsync(RecordEntity entity, CancellationToken token);
        Task DeleteAsync(RecordEntity entity, CancellationToken token);
    }
}
