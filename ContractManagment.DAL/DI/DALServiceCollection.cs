using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Interfaces;
using ContractManagment.DAL.Repositories;
using ContractManagment.DAL.Repositories.ClientDigital;
using ContractManagment.DAL.Repositories.ClientInternet;
using ContractManagment.DAL.Repositories.Post;
using ContractManagment.DAL.Repositories.Record;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContractManagment.DAL.DI
{
    public static class DALServiceCollection
    {
        public static void AddDalServices(this IServiceCollection services, IConfiguration configuration)
        {
            var managmentConnection = configuration.GetConnectionString("ManagmentConnection");
            services.AddDbContext<ManagmentContext>(c => c.UseMySql(managmentConnection, new MySqlServerVersion(new Version(8, 0, 34))));

            var wpConnection = configuration.GetConnectionString("WPConnection");
            services.AddDbContext<WPContext>(c => c.UseMySql(wpConnection, new MySqlServerVersion(new Version(8, 0, 34))));

            var billingInternetConnection = configuration.GetConnectionString("BillingInternetConnection");
            services.AddDbContext<BillingInternetContext>(c => c.UseMySql(billingInternetConnection, new MySqlServerVersion(new Version(8, 0, 34))));

            var billingDigitalConnection = configuration.GetConnectionString("BillingDigitalConnection");
            services.AddDbContext<BillingDigitalContext>(c => c.UseMySql(billingDigitalConnection, new MySqlServerVersion(new Version(8, 0, 34))));

            services.AddScoped<IGenericRepository<KeyEntity>, KeyRepository>();
            services.AddScoped<IGenericRepository<ContractEntity>, ContractRepository>();
            services.AddScoped<IContractKeyRepository, ContractKeyRepository>();

            services.AddScoped<IGenericRepository<RecordEntity>, RecordRepository>();
            services.AddScoped<IGenericRepository<RecordKeyEntity>, RecordKeyRepository>();

            services.AddScoped<IGenericReadRepository<PostEntity>, PostRepository>();
            services.AddScoped<IGenericReadRepository<PostMetaEntity>, PostMetaRepository>();

            services.AddScoped<IGenericReadRepository<AccountTariffInternetEntity>, AccountTariffInternetRepository>();
            services.AddScoped<IGenericReadRepository<TariffInternetEntity>, TariffInternetRepository>();
            services.AddScoped<IGenericReadRepository<ClientInternetEntity>, ClientInterntRepository>();
            services.AddScoped<IGenericReadRepository<InternetAddParamEntity>, InternetAddParamRepository>();
            services.AddScoped<IGenericReadRepository<ClientInternetAddParamEntity>, ClientInternetAddParamRepository>();

            services.AddScoped<IGenericReadRepository<AccountTariffDigitalEntity>, AccountTariffDigitalRepository>();
            services.AddScoped<IGenericReadRepository<TariffDigitalEntity>, TariffDigitalRepository>();
            services.AddScoped<IGenericReadRepository<ClientDigitalEntity>, ClientDigitalRepository>();
            services.AddScoped<IGenericReadRepository<DigitalAddParamEntity>, DigitalAddParamRepository>();
            services.AddScoped<IGenericReadRepository<ClientDigitalAddParamEntity>, ClientDigitalAddParamRepository>();

            services.AddScoped<IGenericRepository<UserEntity>, UserRepository>();

        }
    }
}
