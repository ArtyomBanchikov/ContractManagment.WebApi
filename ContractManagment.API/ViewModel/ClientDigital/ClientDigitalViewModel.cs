using ContractManagment.API.ViewModel.ClientInternet;

namespace ContractManagment.API.ViewModel.ClientDigital
{
    public class ClientDigitalViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Passport { get; set; }
        public int Account { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Flat { get; set; }
        public string Entrance { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Floor { get; set; }
        public string NCamModul { get; set; }
        public List<ClientDigitalAddParamViewModel> Params { get; set; }
    }
}
