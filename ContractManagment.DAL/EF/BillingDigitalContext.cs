using ContractManagment.DAL.Entities.ClientDigital;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.EF
{
    public class BillingDigitalContext : DbContext
    {
        public DbSet<ClientDigitalEntity> ClientsDigital { get; set; } = null!;
        public DbSet<DigitalAddParamEntity> DigitalParameters { get; set; } = null!;
        public DbSet<ClientDigitalAddParamEntity> DigitalAdditionalParameters { get; set; } = null!;
        public BillingDigitalContext(DbContextOptions<BillingDigitalContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientDigitalAddParamEntity>()
                .HasOne(cparam => cparam.Client)
                .WithMany(client => client.Params)
                .HasForeignKey("userid");

            modelBuilder.Entity<ClientDigitalAddParamEntity>()
                .HasOne(cparam => cparam.Parameter)
                .WithMany()
                .HasForeignKey("paramid");
        }
    }
}
