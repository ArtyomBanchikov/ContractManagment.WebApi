using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.ClientDigital;
using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models.ClientDigital;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.ClientDigital
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class AccountTariffDigitalController : GenericReadController<AccountTariffDigitalModel, AccountTariffDigitalViewModel>
    {
        public AccountTariffDigitalController(IGenericReadService<AccountTariffDigitalModel> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
