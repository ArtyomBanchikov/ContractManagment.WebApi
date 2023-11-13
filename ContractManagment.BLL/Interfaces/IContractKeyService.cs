using ContractManagment.BLL.Models;

namespace ContractManagment.BLL.Interfaces
{
    public interface IContractKeyService
    {
        Task<IEnumerable<ContractKeyModel>> GetAllAsync(CancellationToken ct);
        Task<ContractKeyModel> CreateAsync(ContractKeyModel model, CancellationToken ct);
        Task<ContractKeyModel> UpdateAsync(int id, ContractKeyModel model, CancellationToken ct);
    }
}
