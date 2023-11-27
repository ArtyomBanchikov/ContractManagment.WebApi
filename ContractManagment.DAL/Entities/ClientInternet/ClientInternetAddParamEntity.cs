using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.ClientInternet
{
    [Table("user_additional_params")]
    public class ClientInternetAddParamEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        public int userid { get; set; }

        [ForeignKey("userid")]
        public ClientInternetEntity? Client { get; set; }

        public int paramid { get; set; }

        [ForeignKey("paramid")]
        public InternetAddParamEntity? Parameter { get; set; }

        [Column("value")]
        public string Value { get; set; }
    }
}
