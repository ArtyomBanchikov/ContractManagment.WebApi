using AutoMapper;
using ContractManagment.BLL.Interfaces.Recrod;
using ContractManagment.BLL.Models.Record;
using ContractManagment.BLL.Services.Generic;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.Record
{
    public class RecordService : GenericService<RecordModel, RecordEntity>, IRecordService
    {
        public RecordService(IGenericRepository<RecordEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
