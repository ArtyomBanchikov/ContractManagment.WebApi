using ContractManagment.DAL.Infraestructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagment.DAL.Entities.Post
{
    [Table("wp_posts")]
    public class PostEntity
    {
        [Column("ID"), Key]
        public int Id { get; set; }

        [Column("post_type", TypeName = "varchar(20)")]
        public string Type { get; set; } = null!;
        public List<PostMetaEntity> Meta { get; set; } = null!;

        [Column("post_date")]
        public DateTime Date { get; set; }
    }
}
