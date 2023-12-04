using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.ClientDigital
{
    [Table("tariffs")]
    public class TariffDigitalEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("is_deleted")]
        public int IsDeleted { get; set; }
    }
}
