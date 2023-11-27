using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.ClientInternet
{
    public class InternetAddParamRepository : GenericBillingInternetRepository<InternetAddParamEntity>
    {
        public InternetAddParamRepository(BillingInternetContext context) : base(context)
        {
        }
    }
}
