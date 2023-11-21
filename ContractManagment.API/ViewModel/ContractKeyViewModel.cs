namespace ContractManagment.API.ViewModel
{
    public class ContractKeyViewModel
    {
        public int ContractId { get; set; }
        public ContractViewModel? Contract { get; set; }
        public int KeyId { get; set; }
        public KeyViewModel? Key { get; set; }
    }
}
