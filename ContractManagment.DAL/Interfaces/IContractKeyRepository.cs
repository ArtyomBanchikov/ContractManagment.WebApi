using ContractManagment.DAL.Entities;

namespace ContractManagment.DAL.Interfaces
{
    public interface IContractKeyRepository
    {
        Task<IEnumerable<ContractKeyEntity>> GetAllAsync(CancellationToken token);
        Task<ContractKeyEntity> UpdateAsync(ContractKeyEntity entity, CancellationToken token);
        Task<ContractKeyEntity> CreateAsync(ContractKeyEntity entity, CancellationToken token);
    }
}
