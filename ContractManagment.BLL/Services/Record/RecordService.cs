using AutoMapper;
using ContractManagment.BLL.Interfaces.Recrod;
using ContractManagment.BLL.Models.Record;
using ContractManagment.DAL.Entities.Record;
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

        public async Task<RecordModel> CreateAsync(RecordModel model, CancellationToken ct)
        {
            var resultEntity = await _repository.CreateAsync(_mapper.Map<RecordEntity>(model), ct);

            return _mapper.Map<RecordModel>(resultEntity);
        }

        public async Task DeleteByIdAsync(int id, CancellationToken ct)
        {
            var resultEntity = await _repository.GetByIdAsync(id, ct);

            await _repository.DeleteAsync(resultEntity, ct);
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

        public async Task<RecordModel> GetByIdAsync(int id, CancellationToken ct)
        {
            var resultEntity = await _repository.GetByIdAsync(id, ct);

            return _mapper.Map<RecordModel>(resultEntity);
        }

        public async Task<RecordModel> UpdateAsync(int id, RecordModel model, CancellationToken ct)
        {
            var entity = _mapper.Map<RecordEntity>(model);

            var resultEntity = await _repository.UpdateAsync(entity, ct);

            return _mapper.Map<RecordModel>(resultEntity);
        }
    }
}
