using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.ClientDigital;
using ContractManagment.BLL.Interfaces.ClientDigital;
using ContractManagment.BLL.Models.ClientDigital;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.ClientDigital
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class ClientDigitalController : GenericReadController<ClientDigitalModel, ClientDigitalViewModel>
    {
        public ClientDigitalController(IClientDigitalService clientDigitalService, IMapper mapper) : base(clientDigitalService, mapper)
        {

        }
    }
}
