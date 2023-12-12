using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models.Post;

namespace ContractManagment.BLL.Interfaces.Post
{
    public interface IPostService : IGenericReadService<PostModel>
    {
        Task<IEnumerable<PostModel>> GetByFilter(CancellationToken token);
    }
}
