using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Entities.Record;
using Microsoft.EntityFrameworkCore;

namespace ContractManagment.DAL.EF
{
    public class ManagmentContext : DbContext
    {
        public DbSet<KeyEntity> Keys { get; set; } = null!;
        public DbSet<ContractEntity> Contracts { get; set; } = null!;
        public DbSet<UserEntity> Users { get; set; } = null!;
        public DbSet<ContractKeyEntity> ContractKeys { get; set; } = null!;
        public DbSet<RecordEntity> Records { get; set; } = null!;
        public DbSet<RecordKeyEntity> RecordsKeys { get; set; } = null!;

        public ManagmentContext(DbContextOptions<ManagmentContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<KeyEntity>().HasData(
                new KeyEntity { Id = 1, Key = "KeyFIOClient", Name = "Абонент" },
                new KeyEntity { Id = 2, Key = "RegistrationAddress", Name = "Адрес регистрации" },
                new KeyEntity { Id = 3, Key = "KeyInstallStreet", Name = "Улица установки" },
                new KeyEntity { Id = 4, Key = "KeyInstallBuilding", Name = "Дом установки" },
                new KeyEntity { Id = 5, Key = "KeyInstallApartment", Name = "Квартира установки" },
                new KeyEntity { Id = 6, Key = "KeyInstallPorch", Name = "Подъезд" },
                new KeyEntity { Id = 7, Key = "KeyInstallStorey", Name = "Этаж" },
                new KeyEntity { Id = 8, Key = "KeyClientMobilePhone", Name = "Моб.тел" },
                new KeyEntity { Id = 9, Key = "KeyClientHomePhone", Name = "Дом.тел" },
                new KeyEntity { Id = 10, Key = "KeyClientPassportSmallNumber", Name = "Паспорт" },
                new KeyEntity { Id = 11, Key = "KeyClientPassportFullNumber", Name = "Личный номер" },
                new KeyEntity { Id = 12, Key = "KeyClientPassportIssued", Name = "Выдан" }
                );

            modelBuilder.Entity<ContractEntity>()
                .HasMany(e => e.Keys)
                .WithMany(e => e.Contracts)
                .UsingEntity<ContractKeyEntity>(
                l => l.HasOne(e => e.Key).WithMany(),
                r => r.HasOne(e => e.Contract).WithMany());

            modelBuilder.Entity<RecordEntity>()
                .HasMany(r => r.RecordKeys)
                .WithOne(k => k.Record);
        }
    }
}
