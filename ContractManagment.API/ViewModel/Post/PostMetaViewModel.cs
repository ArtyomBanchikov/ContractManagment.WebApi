namespace ContractManagment.API.ViewModel.PostViewModels
{
    public class PostMetaViewModel
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public int PostId { get; set; }
        public PostViewModel? Post { get; set; }
        public string Value { get; set; } = null!;
    }
}
