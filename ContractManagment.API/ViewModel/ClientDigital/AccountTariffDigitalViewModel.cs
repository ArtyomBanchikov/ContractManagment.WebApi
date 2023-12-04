namespace ContractManagment.API.ViewModel.ClientDigital
{
    public class AccountTariffDigitalViewModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TariffId { get; set; }
        public TariffDigitalViewModel? Tariff { get; set; }
        public int IsDeleted { get; set; }
    }
}
