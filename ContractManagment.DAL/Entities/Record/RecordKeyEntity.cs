using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.Record
{
    public class RecordKeyEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string? Value { get; set; }
        public int RecordId { get; set; }

        [ForeignKey("RecordId")]
        public RecordEntity? Record { get; set; }
    }
}
