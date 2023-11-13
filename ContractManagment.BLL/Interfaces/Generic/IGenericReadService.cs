namespace ContractManagment.BLL.Interfaces.Generic
{
    public interface IGenericReadService<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync(CancellationToken ct);
        Task<TModel> GetByIdAsync(int id, CancellationToken ct);
    }
}
