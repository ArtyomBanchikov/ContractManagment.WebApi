namespace ContractManagment.BLL.Models.Post
{
    public class PostMetaModel
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public int PostId { get; set; }
        public PostModel? Post { get; set; }
        public string Value { get; set; } = null!;
    }
}
