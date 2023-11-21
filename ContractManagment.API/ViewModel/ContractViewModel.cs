namespace ContractManagment.API.ViewModel
{
    public class ContractViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<KeyViewModel>? Keys { get; set; }
        public byte[] Value { get; set; } = null!;
    }
}
