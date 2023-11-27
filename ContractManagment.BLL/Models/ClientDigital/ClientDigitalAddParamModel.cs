namespace ContractManagment.BLL.Models.ClientDigital
{
    public class ClientDigitalAddParamModel
    {
        public int Id { get; set; }
        public int userid { get; set; }
        public ClientDigitalModel? Client { get; set; }
        public int paramid { get; set; }
        public DigitalAddParamModel? Parameter { get; set; }
        public string Value { get; set; }
    }
}
