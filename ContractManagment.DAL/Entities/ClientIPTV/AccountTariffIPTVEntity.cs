using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.ClientIPTV
{
    [Table("account_tariff_link")]
    public class AccountTariffIPTVEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("account_id")]
        public int AccountId { get; set; }

        [Column("tariff_id")]
        public int TariffId { get; set; }

        [ForeignKey("TariffId")]
        public TariffIPTVEntity? Tariff { get; set; }

        [Column("is_deleted")]
        public int IsDeleted { get; set; }
    }
}
