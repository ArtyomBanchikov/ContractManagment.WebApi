using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContractManagment.DAL.Entities.ClientDigital
{
    [Table("user_additional_params")]
    public class ClientDigitalAddParamEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        public int userid { get; set; }

        [ForeignKey("userid")]
        public ClientDigitalEntity? Client { get; set; }

        public int paramid { get; set; }

        [ForeignKey("paramid")]
        public DigitalAddParamEntity? Parameter { get; set; }

        [Column("value")]
        public string Value { get; set; }
    }
}
