using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientIPTV;
using ContractManagment.BLL.Models.ClientIPTV;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services.ClientIPTV
{
    public class AccountTariffIPTVService : GenericReadService<AccountTariffIPTVModel, AccountTariffIPTVEntity>, IAccountTariffIPTVService
    {
        public AccountTariffIPTVService(IGenericReadRepository<AccountTariffIPTVEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
