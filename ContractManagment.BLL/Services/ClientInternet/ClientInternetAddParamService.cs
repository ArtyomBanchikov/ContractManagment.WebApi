using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientInternet;
using ContractManagment.BLL.Models.ClientInternet;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services.ClientInternet
{
    public class ClientInternetAddParamService : GenericReadService<ClientInternetAddParamModel, ClientInternetAddParamEntity>, IClientInternetAddParamService
    {
        public ClientInternetAddParamService(IGenericReadRepository<ClientInternetAddParamEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
