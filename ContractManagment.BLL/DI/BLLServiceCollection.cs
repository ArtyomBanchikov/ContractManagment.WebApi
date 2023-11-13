using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Interfaces.Client;
using ContractManagment.BLL.Interfaces.Post;
using ContractManagment.BLL.Services;
using ContractManagment.BLL.Services.Client;
using ContractManagment.BLL.Services.Post;
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

            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IAdditionalParameterService, AdditionalParameterService>();
            services.AddScoped<IClientAddParamService, ClientAddParamService>();

            services.AddScoped<IUserService, UserService>();

            services.AddDalServices(configuration);
        }
    }
}
