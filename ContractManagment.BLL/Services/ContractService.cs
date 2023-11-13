using AutoMapper;
using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Models;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services
{
    public class ContractService : GenericService<ContractModel, ContractEntity>, IContractService
    {
        public ContractService(IGenericRepository<ContractEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
