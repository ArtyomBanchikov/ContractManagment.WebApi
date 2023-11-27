using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.ClientDigital
{
    public class ClientDigitalAddParamRepository : GenericBillingDigitalRepository<ClientDigitalAddParamEntity>
    {
        public ClientDigitalAddParamRepository(BillingDigitalContext context) : base(context)
        {
        }
    }
}
