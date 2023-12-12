using AutoMapper;
using ContractManagment.BLL.Interfaces.Post;
using ContractManagment.BLL.Models.Post;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services.Post
{
    public class PostMetaService : GenericReadService<PostMetaModel, PostMetaEntity>, IPostMetaService
    {
        public PostMetaService(IGenericReadRepository<PostMetaEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
