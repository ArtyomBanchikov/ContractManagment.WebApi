namespace ContractManagment.API.ViewModel.Record
{
    public class RecordKeyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int RecordId { get; set; }
        public RecordViewModel? Record { get; set; }
    }
}
