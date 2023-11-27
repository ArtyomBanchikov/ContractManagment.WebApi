namespace ContractManagment.API.ViewModel.ClientDigital
{
    public class ClientDigitalAddParamViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientDigitalViewModel? Client { get; set; }
        public int ParamId { get; set; }
        public DigitalAddParamViewModel? Parameter { get; set; }
        public string Value { get; set; }
    }
}
