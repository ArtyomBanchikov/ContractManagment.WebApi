namespace ContractManagment.BLL.Models
{
    public class ContractKeyModel
    {
        public int ContractId { get; set; }
        public ContractModel? Contract { get; set; }
        public int KeyId { get; set; }
        public KeyModel? Key { get; set; }
    }
}
