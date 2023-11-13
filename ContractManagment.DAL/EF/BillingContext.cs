using ContractManagment.DAL.Entities.Client;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagment.DAL.EF
{
    public class BillingContext : DbContext
    {
        public DbSet<ClientEntity> Clients { get; set; } = null!;
        public DbSet<AdditionalParameterEntity> Parameters { get; set; } = null!;
        public DbSet<ClientAddParamEntity> AdditionalParameters { get; set; } = null!;
        public BillingContext(DbContextOptions<BillingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientAddParamEntity>()
                .HasOne(cparam => cparam.Client)
                .WithMany(client => client.Params)
                .HasForeignKey("userid");

            modelBuilder.Entity<ClientAddParamEntity>()
                .HasOne(cparam => cparam.Parameter)
                .WithMany()
                .HasForeignKey("paramid");
        }
    }
}
