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
    public class RecordController : GenericController<RecordModel, RecordViewModel>
    {
        public RecordController(IGenericService<RecordModel> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
