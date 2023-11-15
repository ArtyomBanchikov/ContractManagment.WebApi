﻿using AutoMapper;
using ContractManagment.API.ViewModel;
using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class ContractKeyController : Controller
    {
        private readonly IGenericService<ContractKeyModel> _service;
        protected readonly IMapper _mapper;

        public ContractKeyController(IGenericService<ContractKeyModel> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ContractKeyViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var tModels = await _service.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<ContractKeyViewModel>>(tModels);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task CreateAsync([FromBody] ContractKeyViewModel tViewModel, CancellationToken cancellationToken)
        {
            var tModel = _mapper.Map<ContractKeyModel>(tViewModel);
            await _service.CreateAsync(tModel, cancellationToken);
        }

        [HttpPut]
        [Authorize(Roles = "admin")]
        public async Task UpdateAsync(int id, [FromBody] ContractKeyViewModel tViewModel, CancellationToken cancellationToken)
        {
            var tModel = _mapper.Map<ContractKeyModel>(tViewModel);
            await _service.UpdateAsync(id, tModel, cancellationToken);
        }
    }
}