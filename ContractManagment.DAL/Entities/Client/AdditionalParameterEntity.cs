using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.Client
{
    [Table("uaddparams_desc")]
    public class AdditionalParameterEntity
    {
        [Column("paramid"), Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("display_name")]
        public string DisplayName { get; set; }

        [Column("visible")]
        public int Visible { get; set; }
    }
}
