using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Entities.Post;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagment.DAL.EF
{
    public class WPContext : DbContext
    {
        public DbSet<PostEntity> Posts { get; set; } = null!;
        public DbSet<PostEntity> PostMeta { get; set; } = null!;
        public WPContext(DbContextOptions<WPContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PostEntity>()
                .HasMany(e => e.Meta)
                .WithOne()
                .HasForeignKey(m => m.PostId);
        }*/
    }
}
