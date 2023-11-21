namespace ContractManagment.BLL.Models.Record
{
    public class RecordModel
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public List<RecordKeyModel>? RecordKeys { get; set; }
    }
}
