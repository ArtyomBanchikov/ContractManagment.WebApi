using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models.Record;

namespace ContractManagment.BLL.Interfaces.Recrod
{
    public interface IRecordService : IGenericService<RecordModel>
    {
        Task<IEnumerable<RecordModel>> GetByFilter(string keyName, string keyValue, CancellationToken token);
    }
}
