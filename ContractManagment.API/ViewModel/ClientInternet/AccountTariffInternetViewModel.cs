using ContractManagment.BLL.Models.ClientInternet;

namespace ContractManagment.API.ViewModel.ClientInternet
{
    public class AccountTariffInternetViewModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TariffId { get; set; }
        public TariffInternetViewModel? Tariff { get; set; }
        public int IsDeleted { get; set; }
    }
}
