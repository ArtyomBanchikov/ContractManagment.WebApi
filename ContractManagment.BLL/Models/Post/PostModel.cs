namespace ContractManagment.BLL.Models.Post
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public List<PostMetaModel> Meta { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
