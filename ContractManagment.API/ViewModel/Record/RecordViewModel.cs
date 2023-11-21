namespace ContractManagment.API.ViewModel.Record
{
    public class RecordViewModel
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public List<RecordKeyViewModel>? RecordKeys { get; set; }
    }
}
