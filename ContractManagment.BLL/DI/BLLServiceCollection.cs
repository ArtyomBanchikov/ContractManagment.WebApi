using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Interfaces.ClientDigital;
using ContractManagment.BLL.Interfaces.ClientInternet;
using ContractManagment.BLL.Interfaces.Post;
using ContractManagment.BLL.Interfaces.Recrod;
using ContractManagment.BLL.Services;
using ContractManagment.BLL.Services.ClientDigital;
using ContractManagment.BLL.Services.ClientInternet;
using ContractManagment.BLL.Services.Post;
using ContractManagment.BLL.Services.Record;
using ContractManagment.DAL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContractManagment.BLL.DI
{
    public static class BLLServiceCollection
    {
        public static void AddBllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPostMetaService, PostMetaService>();

            services.AddScoped<IKeyService, KeyService>();
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IContractKeyService, ContractKeyService>();

            services.AddScoped<IRecordKeyService, RecordKeyService>();
            services.AddScoped<IRecordService, RecordService>();

            services.AddScoped<IClientInternetService, ClientInternetService>();
            services.AddScoped<IInternetAddParamService, InternetAddParamService>();
            services.AddScoped<IClientInternetAddParamService, ClientInternetAddParamService>();

            services.AddScoped<IClientDigitalService, ClientDigitalService>();
            services.AddScoped<IDigitalAddParamService, DigitalAddParamService>();
            services.AddScoped<IClientDigitalAddParamService, ClientDigitalAddParamService>();

            services.AddScoped<IUserService, UserService>();

            services.AddDalServices(configuration);
        }
    }
}
