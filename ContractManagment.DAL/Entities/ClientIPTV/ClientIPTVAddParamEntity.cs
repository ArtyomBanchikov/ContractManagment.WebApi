using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.ClientIPTV
{
    [Table("user_additional_params")]
    public class ClientIPTVAddParamEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        public int userid { get; set; }

        [ForeignKey("userid")]
        public ClientIPTVEntity? Client { get; set; }

        public int paramid { get; set; }

        [ForeignKey("paramid")]
        public IPTVAddParamEntity? Parameter { get; set; }

        [Column("value")]
        public string Value { get; set; }
    }
}
