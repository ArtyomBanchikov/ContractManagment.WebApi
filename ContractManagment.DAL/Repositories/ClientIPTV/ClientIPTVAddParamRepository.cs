using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientIPTV;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.ClientIPTV
{
    public class ClientIPTVAddParamRepository : GenericBillingIPTVRepository<ClientIPTVAddParamEntity>
    {
        public ClientIPTVAddParamRepository(BillingIPTVContext context) : base(context)
        {
        }
    }
}
