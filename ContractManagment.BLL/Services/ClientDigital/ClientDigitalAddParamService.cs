using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientDigital;
using ContractManagment.BLL.Models.ClientDigital;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services.ClientDigital
{
    public class ClientDigitalAddParamService : GenericReadService<ClientDigitalAddParamModel, ClientDigitalAddParamEntity>, IClientDigitalAddParamService
    {
        public ClientDigitalAddParamService(IGenericReadRepository<ClientDigitalAddParamEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
