﻿namespace ContractManagment.API.ViewModel.ClientInternet
{
    public class ClientInternetViewModel
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
        public DateOnly ConnectDate { get; set; }
        public List<ClientInternetAddParamViewModel> Params { get; set; }
    }
}
