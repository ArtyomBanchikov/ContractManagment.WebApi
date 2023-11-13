using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Post
{
    public class PostRepository : GenericWPRepository<PostEntity>
    {
        public PostRepository(WPContext context) : base(context)
        {
        }

        public new async Task<IEnumerable<PostEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.Where(r => r.Type == "post_user_request").AsNoTracking().ToListAsync(token);
        }
    }
}
