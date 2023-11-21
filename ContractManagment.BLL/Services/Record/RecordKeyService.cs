using AutoMapper;
using ContractManagment.BLL.Interfaces.Recrod;
using ContractManagment.BLL.Models.Record;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.Record
{
    public class RecordKeyService : GenericService<RecordKeyModel, RecordKeyEntity>, IRecordKeyService
    {
        public RecordKeyService(IGenericRepository<RecordKeyEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
