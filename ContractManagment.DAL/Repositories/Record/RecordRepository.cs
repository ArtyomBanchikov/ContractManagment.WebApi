using ContractManagment.DAL.EF;
using ContractManagment.DAL.Entities.Record;
using ContractManagment.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagment.DAL.Repositories.Record
{
    public class RecordRepository : GenericManagmentRepository<RecordEntity>
    {
        public RecordRepository(ManagmentContext context) : base(context)
        {
        }
    }
}
