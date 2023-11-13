using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Client;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.Client
{
    public class AdditionalParameterRepository : GenericBillingRepository<AdditionalParameterEntity>
    {
        public AdditionalParameterRepository(BillingContext context) : base(context)
        {
        }
    }
}
