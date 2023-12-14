using AutoMapper;
using ContractManagment.BLL.Interfaces.Post;
using ContractManagment.BLL.Models.Post;
using ContractManagment.DAL.Interfaces;

namespace ContractManagment.BLL.Services.Post
{
    public class PostService : IPostService
    {
        protected readonly IPostRepository _repository;

        protected readonly IMapper _mapper;

        public PostService(IPostRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostModel>> GetAllAsync(CancellationToken ct)
        {
            var result = _mapper.Map<IEnumerable<PostModel>>(await _repository.GetAllAsync(ct));

            return result;
        }

        public async Task<IEnumerable<PostModel>> GetByFilter(CancellationToken token)
        {
            var result = await _repository.GetByFilter(token);
            return _mapper.Map<IEnumerable<PostModel>>(result);
        }

        public async Task<PostModel> GetByIdAsync(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
