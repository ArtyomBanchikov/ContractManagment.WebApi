using AutoMapper;
using ContractManagment.BLL.Interfaces.Generic;
using ContractManagment.DAL.Infraestructure;
using ContractManagment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagment.BLL.Services.Generic
{
    public class GenericReadService<TModel, TEntity> : IGenericReadService<TModel>
        where TModel : class
        where TEntity : class
    {
        protected readonly IGenericReadRepository<TEntity> repository;

        protected readonly IMapper mapper;

        public GenericReadService(IGenericReadRepository<TEntity> genericRepository, IMapper mapper)
        {
            repository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync(CancellationToken ct)
        {
            var result = mapper.Map<IEnumerable<TModel>>(await repository.GetAllAsync(ct));

            return result;
        }

        public async Task<TModel> GetByIdAsync(int id, CancellationToken ct)
        {
            var resultEntity = await repository.GetByIdAsync(id, ct);

            return mapper.Map<TModel>(resultEntity);
        }
    }
}
