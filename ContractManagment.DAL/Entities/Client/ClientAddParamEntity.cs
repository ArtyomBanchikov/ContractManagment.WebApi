using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.Client
{
    [Table("user_additional_params")]
    public class ClientAddParamEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        public int userid { get; set; }

        [ForeignKey("userid")]
        public ClientEntity? Client { get; set; }

        public int paramid { get; set; }

        [ForeignKey("paramid")]
        public AdditionalParameterEntity? Parameter { get; set; }

        [Column("value")]
        public string Value { get; set; }
    }
}
