﻿using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Entities.Post;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Interfaces;
using ContractManagment.DAL.Interfaces.Generic;
using ContractManagment.DAL.Repositories;
using ContractManagment.DAL.Repositories.ClientDigital;
using ContractManagment.DAL.Repositories.ClientInternet;
using ContractManagment.DAL.Repositories.ClientIPTV;
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

            var billingIPTVConnection = configuration.GetConnectionString("BillingIPTVConnection");
            services.AddDbContext<BillingIPTVContext>(c => c.UseMySql(billingIPTVConnection, new MySqlServerVersion(new Version(8, 0, 34))));

            services.AddScoped<IGenericRepository<KeyEntity>, KeyRepository>();
            services.AddScoped<IGenericRepository<ContractEntity>, ContractRepository>();
            services.AddScoped<IContractKeyRepository, ContractKeyRepository>();

            services.AddScoped<IRecordRepository, RecordRepository>();
            services.AddScoped<IGenericRepository<RecordKeyEntity>, RecordKeyRepository>();

            services.AddScoped<IPostRepository, PostRepository>();
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

            services.AddScoped<IGenericReadRepository<AccountTariffIPTVEntity>, AccountTariffIPTVRepository>();
            services.AddScoped<IGenericReadRepository<TariffIPTVEntity>, TariffIPTVRepository>();
            services.AddScoped<IGenericReadRepository<ClientIPTVEntity>, ClientIPTVRepository>();
            services.AddScoped<IGenericReadRepository<IPTVAddParamEntity>, IPTVAddParamRepository>();
            services.AddScoped<IGenericReadRepository<ClientIPTVAddParamEntity>, ClientIPTVAddParamRepository>();

            services.AddScoped<IGenericRepository<UserEntity>, UserRepository>();

        }
    }
}
