using AutoMapper;
using ContractManagment.BLL.Interfaces.Recrod;
using ContractManagment.BLL.Models.Record;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.Record
{
    public class RecordService : IRecordService
    {
        protected readonly IRecordRepository _repository;

        protected readonly IMapper _mapper;
        public RecordService(IRecordRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<RecordModel> CreateAsync(RecordModel model, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RecordModel>> GetAllAsync(CancellationToken ct)
        {
            var result = _mapper.Map<IEnumerable<RecordModel>>(await _repository.GetAllAsync(ct));

            return result;
        }

        public async Task<IEnumerable<RecordModel>> GetByFilter(string keyName, string keyValue, CancellationToken token)
        {
            var result = await _repository.GetByFilter(keyName, keyValue, token);
            return _mapper.Map<IEnumerable<RecordModel>>(result);
        }

        public Task<RecordModel> GetByIdAsync(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<RecordModel> UpdateAsync(int id, RecordModel model, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
