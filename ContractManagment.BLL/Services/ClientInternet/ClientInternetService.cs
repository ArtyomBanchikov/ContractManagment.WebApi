using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientInternet;
using ContractManagment.BLL.Models.ClientInternet;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.ClientInternet
{
    public class ClientInternetService : GenericReadService<ClientInternetModel, ClientInternetEntity>, IClientInternetService
    {
        public ClientInternetService(IGenericReadRepository<ClientInternetEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
