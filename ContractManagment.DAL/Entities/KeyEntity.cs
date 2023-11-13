using System.ComponentModel.DataAnnotations;

namespace ContractManagment.DAL.Entities
{
    public class KeyEntity
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; } = null!;
        public string Key { get; set; } = null!;
        public List<ContractEntity> Contracts { get; set; }
    }
}
