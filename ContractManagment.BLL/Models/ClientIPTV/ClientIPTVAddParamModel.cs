namespace ContractManagment.BLL.Models.ClientIPTV
{
    public class ClientIPTVAddParamModel
    {
        public int Id { get; set; }
        public int userid { get; set; }
        public ClientIPTVModel? Client { get; set; }
        public int paramid { get; set; }
        public IPTVAddParamModel? Parameter { get; set; }
        public string Value { get; set; }
    }
}
