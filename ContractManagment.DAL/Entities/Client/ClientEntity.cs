using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagment.DAL.Entities.Client
{
    [Table("users")]
    public class ClientEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("full_name")]
        public string FullName { get; set; }

        [Column("passport")]
        public string Passport { get; set; }

        [Column("basic_account")]
        public int Account { get; set; }

        [Column("mobile_telephone")]
        public string MobilePhone { get; set; }

        [Column("home_telephone")]
        public string HomePhone { get; set; }

        [Column("flat_number")]
        public string Flat {  get; set; }

        [Column("entrance")]
        public string Entrance { get; set; }

        [Column("building")]
        public string Building { get; set; }

        public List<ClientAddParamEntity> Params { get; set; }
    }
}
