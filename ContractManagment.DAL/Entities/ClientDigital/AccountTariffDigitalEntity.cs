using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.ClientDigital
{
    [Table("account_tariff_link")]
    public class AccountTariffDigitalEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("account_id")]
        public int AccountId { get; set; }

        [Column("tariff_id")]
        public int TariffId { get; set; }

        [ForeignKey("TariffId")]
        public TariffDigitalEntity? Tariff { get; set; }

        [Column("is_deleted")]
        public int IsDeleted { get; set; }
    }
}
