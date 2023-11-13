using ContractManagment.DAL.Infraestructure;
using System.ComponentModel.DataAnnotations;

namespace ContractManagment.DAL.Entities
{
    public class ContractEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<KeyEntity> Keys { get; set; }
        public byte[] Value { get; set; } = null!;
    }
}
