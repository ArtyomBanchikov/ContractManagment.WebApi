using ContractManagment.DAL.Entities.ClientIPTV;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.EF
{
    public class BillingIPTVContext : DbContext
    {
        public DbSet<ClientIPTVEntity> ClientsIPTV { get; set; } = null!;
        public DbSet<IPTVAddParamEntity> IPTVParameters { get; set; } = null!;
        public DbSet<ClientIPTVAddParamEntity> IPTVAdditionalParameters { get; set; } = null!;
        public DbSet<AccountTariffIPTVEntity> AccountTariffsIPTV { get; set; } = null!;
        public DbSet<TariffIPTVEntity> TariffsIPTV { get; set; } = null!;
        public BillingIPTVContext(DbContextOptions<BillingInternetContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientIPTVAddParamEntity>()
                .HasOne(cparam => cparam.Client)
                .WithMany(client => client.Params)
                .HasForeignKey("userid");

            modelBuilder.Entity<ClientIPTVAddParamEntity>()
                .HasOne(cparam => cparam.Parameter)
                .WithMany()
                .HasForeignKey("paramid");
        }
    }
}
