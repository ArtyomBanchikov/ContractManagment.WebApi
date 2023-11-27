using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContractManagment.DAL.Entities.ClientDigital
{
    [Table("uaddparams_desc")]
    public class DigitalAddParamEntity
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
