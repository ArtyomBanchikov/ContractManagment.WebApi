using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Entities.Client;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Interfaces;
using ContractManagment.DAL.Repositories;
using ContractManagment.DAL.Repositories.Client;
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

            var billingConnection = configuration.GetConnectionString("BillingConnection");
            services.AddDbContext<BillingContext>(c => c.UseMySql(billingConnection, new MySqlServerVersion(new Version(8, 0, 34))));

            services.AddScoped<IGenericRepository<KeyEntity>, KeyRepository>();
            services.AddScoped<IGenericRepository<ContractEntity>, ContractRepository>();
            services.AddScoped<IContractKeyRepository, ContractKeyRepository>();

            services.AddScoped<IGenericRepository<RecordEntity>, RecordRepository>();
            services.AddScoped<IGenericRepository<RecordKeyEntity>, RecordKeyRepository>();

            services.AddScoped<IGenericReadRepository<PostEntity>, PostRepository>();
            services.AddScoped<IGenericReadRepository<PostMetaEntity>, PostMetaRepository>();

            services.AddScoped<IGenericReadRepository<ClientEntity>, ClientRepository>();
            services.AddScoped<IGenericReadRepository<AdditionalParameterEntity>, AdditionalParameterRepository>();
            services.AddScoped<IGenericReadRepository<ClientAddParamEntity>, ClientAddParamRepository>();

            services.AddScoped<IGenericRepository<UserEntity>, UserRepository>();

        }
    }
}
