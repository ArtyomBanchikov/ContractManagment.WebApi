namespace ContractManagment.API.ViewModel.ClientInternet
{
    public class ClientInternetAddParamViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientInternetViewModel? Client { get; set; }
        public int ParamId { get; set; }
        public InternetAddParamViewModel? Parameter { get; set; }
        public string Value { get; set; }
    }
}
