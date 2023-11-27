using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientInternet;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.ClientInternet
{
    public class ClientInternetAddParamRepository : GenericBillingInternetRepository<ClientInternetAddParamEntity>
    {
        public ClientInternetAddParamRepository(BillingInternetContext context) : base(context)
        {
        }
    }
}
