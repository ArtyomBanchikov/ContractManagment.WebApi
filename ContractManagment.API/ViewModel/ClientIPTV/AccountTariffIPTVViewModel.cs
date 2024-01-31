namespace ContractManagment.API.ViewModel.ClientIPTV
{
    public class AccountTariffIPTVViewModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TariffId { get; set; }
        public TariffIPTVViewModel? Tariff { get; set; }
        public int IsDeleted { get; set; }
    }
}
