using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagment.DAL.Entities.Record
{
    public class RecordEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public List<RecordKeyEntity>? RecordKeys { get; set; }
    }
}
