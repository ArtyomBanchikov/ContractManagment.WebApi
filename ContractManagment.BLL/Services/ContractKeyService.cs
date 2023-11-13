using AutoMapper;
using ContractManagment.BLL.Interfaces;
using ContractManagment.BLL.Models;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services
{
    public class ContractKeyService : IContractKeyService
    {
        protected readonly IContractKeyRepository _repository;

        protected readonly IMapper _mapper;

        public ContractKeyService(IContractKeyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ContractKeyModel> CreateAsync(ContractKeyModel model, CancellationToken ct)
        {
            var resultEntity = await _repository.CreateAsync(_mapper.Map<ContractKeyEntity>(model), ct);

            return _mapper.Map<ContractKeyModel>(resultEntity);
        }

        public async Task<IEnumerable<ContractKeyModel>> GetAllAsync(CancellationToken ct)
        {
            var result = _mapper.Map<IEnumerable<ContractKeyModel>>(await _repository.GetAllAsync(ct));

            return result;
        }

        public async Task<ContractKeyModel> UpdateAsync(int id, ContractKeyModel model, CancellationToken ct)
        {
            var entity = _mapper.Map<ContractKeyEntity>(model);

            var resultEntity = await _repository.UpdateAsync(entity, ct);

            return _mapper.Map<ContractKeyModel>(resultEntity);
        }
    }
}
