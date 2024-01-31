namespace ContractManagment.API.ViewModel.ClientIPTV
{
    public class ClientIPTVAddParamViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientIPTVViewModel? Client { get; set; }
        public int ParamId { get; set; }
        public IPTVAddParamViewModel? Parameter { get; set; }
        public string Value { get; set; }
    }
}
