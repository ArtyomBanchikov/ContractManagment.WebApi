namespace ContractManagment.API.ViewModel
{
    public class KeyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Key { get; set; } = null!;
        public List<ContractViewModel>? Contracts { get; set; }
        public bool IsAllowToDelete { get; set; }
    }
}
