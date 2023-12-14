using AutoMapper;
using ContractManagment.API.ViewModel.PostViewModels;
using ContractManagment.API.ViewModel.Record;
using ContractManagment.BLL.Interfaces.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.Post
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _service;
        protected readonly IMapper _mapper;
        public PostController(IPostService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{keyName}/{keyValue}")]
        public async Task<IEnumerable<LongRecordViewModel>> GetByFilter([FromRoute] string keyName, [FromRoute] string keyValue, CancellationToken cancellationToken)
        {
            var models = await _service.GetByFilter(cancellationToken);
            var records = _mapper.Map<IEnumerable<PostViewModel>>(models);
            return _mapper
                .Map<IEnumerable<LongRecordViewModel>>(records)
                .Where(record => record.Record.RecordKeys.FirstOrDefault(recordKey => recordKey.Name == keyName && recordKey.Value == keyValue) != null);
        }

        [HttpGet]
        public async Task<IEnumerable<LongRecordViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var tModels = await _service.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<LongRecordViewModel>>(_mapper.Map<IEnumerable<PostViewModel>>(tModels));
        }

        [HttpGet("{id}")]
        public async Task<PostViewModel> GetByIdAsync([FromRoute] int id, CancellationToken cancellationToken)
        {
            var tModel = await _service.GetByIdAsync(id, cancellationToken);

            return _mapper.Map<PostViewModel>(tModel);
        }
    }
}
