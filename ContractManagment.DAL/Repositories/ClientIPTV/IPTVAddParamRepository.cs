using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.ClientIPTV
{
    public class IPTVAddParamRepository : GenericBillingIPTVRepository<IPTVAddParamEntity>
    {
        public IPTVAddParamRepository(BillingIPTVContext context) : base(context)
        {
        }
    }
}
