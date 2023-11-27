using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.ClientDigital;
using ContractManagment.DAL.Repositories.Generic;

namespace ContractManagment.DAL.Repositories.ClientDigital
{
    public class DigitalAddParamRepository : GenericBillingDigitalRepository<DigitalAddParamEntity>
    {
        public DigitalAddParamRepository(BillingDigitalContext context) : base(context)
        {
        }
    }
}
