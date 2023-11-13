namespace ContractManagment.API.ViewModel.Client
{
    public class ClientAddParamViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientViewModel Client { get; set; }
        public int ParamId { get; set; }
        public AdditionalParameterViewModel Parameter { get; set; }
        public string Value { get; set; }
    }
}
