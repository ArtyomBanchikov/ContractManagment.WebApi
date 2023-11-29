using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.ClientInternet;
using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models.ClientInternet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.ClientInternet
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class TariffInternetController : GenericReadController<TariffInternetModel, TariffInternetViewModel>
    {
        public TariffInternetController(IGenericReadService<TariffInternetModel> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
