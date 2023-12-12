using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.Repositories.Post
{
    public class PostRepository : IPostRepository
    {
        protected readonly WPContext context;

        protected readonly DbSet<PostEntity> dbSet;
        public PostRepository(WPContext context)
        {
            this.context = context;
            dbSet = context.Set<PostEntity>();
        }

        public async Task<IEnumerable<PostEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.Where(r => r.Type == "post_user_request")
                .Include(post => post.Meta)
                .OrderByDescending(post => post.Date)
                .Take(100)
                .AsNoTracking()
                .ToListAsync(token);
        }

        public async Task<IEnumerable<PostEntity>> GetByFilter(CancellationToken token)
        {
            return await dbSet.Where(r => r.Type == "post_user_request")
                .AsNoTracking()
                .Include(post => post.Meta)
                .ToListAsync(token);
        }

        public Task<PostEntity?> GetByIdAsync(int id, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
