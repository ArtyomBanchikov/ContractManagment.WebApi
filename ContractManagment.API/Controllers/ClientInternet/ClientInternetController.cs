using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.ClientInternet;
using ContractManagment.BLL.Interfaces.ClientInternet;
using ContractManagment.BLL.Models.ClientInternet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.ClientInternet
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class ClientInternetController : GenericReadController<ClientInternetModel, ClientInternetViewModel>
    {
        public ClientInternetController(IClientInternetService clientInternetService, IMapper mapper) : base(clientInternetService, mapper)
        {

        }
    }
}
