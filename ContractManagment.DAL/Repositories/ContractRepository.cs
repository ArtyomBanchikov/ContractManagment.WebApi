using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories
{
    public  class ContractRepository : GenericManagmentRepository<ContractEntity>
    {
        public ContractRepository(ManagmentContext context) : base(context)
        {
        }
        public override async Task<ContractEntity> CreateAsync(ContractEntity entity, CancellationToken token)
        {
            if (entity.Keys != null && entity.Keys.Count > 0)
            {
                List<KeyEntity> keys = new List<KeyEntity>();
                foreach (var key in entity.Keys)
                {
                    keys.Add(await context.Keys.FindAsync(key.Id, token));
                }
                entity.Keys = keys;
            }
            await context.Contracts.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
