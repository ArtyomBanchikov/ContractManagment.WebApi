using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.Record;
using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models.Record;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.Record
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class RecordKeyController : GenericController<RecordKeyModel, RecordKeyViewModel>
    {
        public RecordKeyController(IGenericService<RecordKeyModel> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
