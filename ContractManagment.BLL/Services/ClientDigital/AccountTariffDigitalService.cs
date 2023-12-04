using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientDigital;
using ContractManagment.BLL.Models.ClientDigital;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.ClientDigital
{
    public class AccountTariffDigitalService : GenericReadService<AccountTariffDigitalModel, AccountTariffDigitalEntity>, IAccountTariffDigitalService
    {
        public AccountTariffDigitalService(IGenericReadRepository<AccountTariffDigitalEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
