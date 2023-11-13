using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.Post
{
    public class PostMetaRepository : GenericWPRepository<PostMetaEntity>
    {
        public PostMetaRepository(WPContext context) : base(context)
        {
        }
    }
}
