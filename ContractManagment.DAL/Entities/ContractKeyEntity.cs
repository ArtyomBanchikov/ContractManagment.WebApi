using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities
{
    public class ContractKeyEntity
    {
        public int ContractId { get; set; }

        [ForeignKey("ContractId")]
        public ContractEntity? Contract { get; set; }
        public int KeyId {  get; set; }

        [ForeignKey("KeyId")]
        public KeyEntity? Key { get; set; }
    }
}
