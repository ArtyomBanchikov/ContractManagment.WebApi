using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientDigital;
using ContractManagment.BLL.Models.ClientDigital;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services.ClientDigital
{
    internal class TariffDigitalService : GenericReadService<TariffDigitalModel, TariffDigitalEntity>, ITariffDigitalService
    {
        public TariffDigitalService(IGenericReadRepository<TariffDigitalEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
