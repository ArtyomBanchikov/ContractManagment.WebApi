using AutoMapper;
using ContractManagment.API.ViewModel.Record;
using ContractManagment.BLL.Interfaces.Recrod;
using ContractManagment.BLL.Models.Record;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.Record
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class RecordController : Controller
    {
        private readonly IRecordService _service;
        protected readonly IMapper _mapper;
        public RecordController(IRecordService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpGet("{keyName}/{keyValue}")]
        public async Task<IEnumerable<LongRecordViewModel>> GetByFilter([FromRoute] string keyName, [FromRoute] string keyValue, CancellationToken cancellationToken)
        {
            var models = await _service.GetByFilter(keyName, keyValue, cancellationToken);
            var records = _mapper.Map<IEnumerable<RecordViewModel>>(models);
            return _mapper.Map<IEnumerable<LongRecordViewModel>>(records);
        }

        [HttpGet]
        public async Task<IEnumerable<LongRecordViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var tModels = await _service.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<LongRecordViewModel>>(_mapper.Map<IEnumerable<RecordViewModel>>(tModels));
        }

        [HttpGet("{id}")]
        public async Task<RecordViewModel> GetByIdAsync([FromRoute] int id, CancellationToken cancellationToken)
        {
            var tModel = await _service.GetByIdAsync(id, cancellationToken);

            return _mapper.Map<RecordViewModel>(tModel);
        }
        [HttpPost]
        public async Task CreateAsync([FromBody] RecordViewModel tViewModel, CancellationToken cancellationToken)
        {
            var tModel = _mapper.Map<RecordModel>(tViewModel);
            await _service.CreateAsync(tModel, cancellationToken);
        }
    }
}
