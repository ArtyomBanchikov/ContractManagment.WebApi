using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientInternet;
using ContractManagment.BLL.Models.ClientInternet;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.ClientInternet
{
    public class TariffInternetService : GenericReadService<TariffInternetModel, TariffInternetEntity>, ITariffInternetService
    {
        public TariffInternetService(IGenericReadRepository<TariffInternetEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
