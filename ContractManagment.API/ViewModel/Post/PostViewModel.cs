namespace ContractManagment.API.ViewModel.PostViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public List<PostMetaViewModel> Meta { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
