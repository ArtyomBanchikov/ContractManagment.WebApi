using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.Client;
using ContractManagment.BLL.Interfaces.Client;
using ContractManagment.BLL.Models.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.Client
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class ClientAddParamController : GenericReadController<ClientAddParamModel, ClientAddParamViewModel>
    {
        public ClientAddParamController(IClientAddParamService clientAddParamService, IMapper mapper) : base(clientAddParamService, mapper)
        {

        }
    }
}
