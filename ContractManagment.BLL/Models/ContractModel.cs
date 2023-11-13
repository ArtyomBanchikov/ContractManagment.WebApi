namespace ContractManagment.BLL.Models
{
    public class ContractModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<KeyModel> Keys { get; set; }
        public byte[] Value { get; set; } = null!;
    }
}
