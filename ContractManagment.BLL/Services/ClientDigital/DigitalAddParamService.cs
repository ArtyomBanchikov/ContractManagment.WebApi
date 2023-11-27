using AutoMapper;
using ContractManagment.BLL.Interfaces.ClientDigital;
using ContractManagment.BLL.Models.ClientDigital;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.ClientDigital
{
    public class DigitalAddParamService : GenericReadService<DigitalAddParamModel, DigitalAddParamEntity>, IDigitalAddParamService
    {
        public DigitalAddParamService(IGenericReadRepository<DigitalAddParamEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
