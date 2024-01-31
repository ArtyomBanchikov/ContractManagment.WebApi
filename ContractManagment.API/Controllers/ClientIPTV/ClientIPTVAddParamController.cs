using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.ClientIPTV;
using ContractManagment.BLL.Interfaces.ClientIPTV;
using ContractManagment.BLL.Models.ClientIPTV;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.ClientIPTV
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class ClientIPTVAddParamController : GenericReadController<ClientIPTVAddParamModel, ClientIPTVAddParamViewModel>
    {
        public ClientIPTVAddParamController(IClientIPTVAddParamService clientIPTVAddParamService, IMapper mapper) : base(clientIPTVAddParamService, mapper)
        {

        }
    }
}
