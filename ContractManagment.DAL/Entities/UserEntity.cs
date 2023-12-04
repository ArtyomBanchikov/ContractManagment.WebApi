using System.ComponentModel.DataAnnotations;

namespace ContractManagment.DAL.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? FIO { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
