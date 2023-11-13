namespace ContractManagment.BLL.Models.Client
{
    public class ClientAddParamModel
    {
        public int Id { get; set; }
        public int userid { get; set; }
        public ClientModel Client { get; set; }
        public int paramid { get; set; }
        public AdditionalParameterModel Parameter { get; set; }
        public string Value { get; set; }
    }
}
