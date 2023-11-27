namespace ContractManagment.BLL.Models.ClientInternet
{
    public class ClientInternetAddParamModel
    {
        public int Id { get; set; }
        public int userid { get; set; }
        public ClientInternetModel? Client { get; set; }
        public int paramid { get; set; }
        public InternetAddParamModel? Parameter { get; set; }
        public string Value { get; set; }
    }
}
