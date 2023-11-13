using AutoMapper;
using ContractManagment.BLL.Interfaces.Client;
using ContractManagment.BLL.Models.Client;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.Client;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.Client
{
    public class AdditionalParameterService : GenericReadService<AdditionalParameterModel, AdditionalParameterEntity>, IAdditionalParameterService
    {
        public AdditionalParameterService(IGenericReadRepository<AdditionalParameterEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
