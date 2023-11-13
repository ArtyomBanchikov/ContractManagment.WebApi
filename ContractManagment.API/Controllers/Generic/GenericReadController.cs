using AutoMapper;
using ContractManagment.BLL.Interfaces.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.Generic
{
    [ApiController]
    [Route("[Controller]")]
    public class GenericReadController<TModel, TViewModel> : Controller
        where TViewModel : class
        where TModel : class
    {
        private readonly IGenericReadService<TModel> _service;
        protected readonly IMapper _mapper;

        public GenericReadController(IGenericReadService<TModel> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<TViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var tModels = await _service.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<TViewModel>>(tModels);
        }

        [HttpGet("{id}")]
        public async Task<TViewModel> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var tModel = await _service.GetByIdAsync(id, cancellationToken);

            return _mapper.Map<TViewModel>(tModel);
        }
    }
}
