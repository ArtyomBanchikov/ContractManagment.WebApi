namespace ContractManagment.BLL.Models
{
    public class KeyModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Key { get; set; } = null!;
        public List<ContractModel>? Contracts { get; set; }
        public bool IsAllowToDelete { get; set; }
    }
}
