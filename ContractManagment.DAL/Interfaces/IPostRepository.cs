using ContractManagment.DAL.Entities.Post;

namespace ContractManagment.DAL.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<PostEntity>> GetAllAsync(CancellationToken token);
        Task<PostEntity?> GetByIdAsync(int id, CancellationToken token);
        Task<IEnumerable<PostEntity>> GetByFilter(CancellationToken token);
    }
}
