using ContractManagment.DAL.Entities.ClientInternet;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.EF
{
    public class BillingInternetContext : DbContext
    {
        public DbSet<ClientInternetEntity> ClientsInternet { get; set; } = null!;
        public DbSet<InternetAddParamEntity> InternetParameters { get; set; } = null!;
        public DbSet<ClientInternetAddParamEntity> InternetAdditionalParameters { get; set; } = null!;
        public BillingInternetContext(DbContextOptions<BillingInternetContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientInternetAddParamEntity>()
                .HasOne(cparam => cparam.Client)
                .WithMany(client => client.Params)
                .HasForeignKey("userid");

            modelBuilder.Entity<ClientInternetAddParamEntity>()
                .HasOne(cparam => cparam.Parameter)
                .WithMany()
                .HasForeignKey("paramid");
        }
    }
}
