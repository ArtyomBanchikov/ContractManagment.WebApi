using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.Post
{
    [Table("wp_postmeta")]
    public class PostMetaEntity
    {
        [Column("meta_id"), Key]
        public int Id { get; set; }

        [Column("meta_key", TypeName = "varchar(255)")]
        public string Key { get; set; } = null!;

        [Column("post_id")]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public PostEntity? Post { get; set; }

        [Column("meta_value", TypeName = "varchar(255)")]
        public string Value { get; set; } = null!;
    }
}
