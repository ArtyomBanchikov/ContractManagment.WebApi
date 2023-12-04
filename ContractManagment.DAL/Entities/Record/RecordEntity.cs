using System.ComponentModel.DataAnnotations;

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
