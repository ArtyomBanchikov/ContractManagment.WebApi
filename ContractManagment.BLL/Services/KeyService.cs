using AutoMapper;
using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Models;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Interfaces.Generic;

namespace ContractManagment.BLL.Services
{
    public class KeyService : GenericService<KeyModel, KeyEntity>, IKeyService
    {
        public KeyService(IGenericRepository<KeyEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
