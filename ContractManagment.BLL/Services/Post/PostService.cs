using AutoMapper;
using ContractManagment.BLL.Interfaces.Post;
using ContractManagment.BLL.Models.Post;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.Post
{
    public class PostService : GenericReadService<PostModel, PostEntity>, IPostService
    {
        public PostService(IGenericReadRepository<PostEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
