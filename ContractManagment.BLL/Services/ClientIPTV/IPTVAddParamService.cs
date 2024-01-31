using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientIPTV;
using ContractManagment.BLL.Models.ClientIPTV;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services.ClientIPTV
{
    public class IPTVAddParamService : GenericReadService<IPTVAddParamModel, IPTVAddParamEntity>, IIPTVAddParamService
    {
        public IPTVAddParamService(IGenericReadRepository<IPTVAddParamEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
