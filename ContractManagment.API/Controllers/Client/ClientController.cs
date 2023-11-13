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
    public class ClientController : GenericReadController<ClientModel, ClientViewModel>
    {
        public ClientController(IClientService clientService, IMapper mapper) : base(clientService, mapper)
        {

        }
    }
}
