﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContractManagment.DAL.Entities.ClientDigital
{
    [Table("users")]
    public class ClientDigitalEntity
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
        public string Flat { get; set; }

        [Column("entrance")]
        public string Entrance { get; set; }

        [Column("building")]
        public string Building { get; set; }

        [Column("actual_address", TypeName = "text")]
        public string Street { get; set; }

        [Column("floor")]
        public string Floor { get; set; }

        [Column("login")]
        public string NCamModul { get; set; }

        public List<ClientDigitalAddParamEntity>? Params { get; set; }
    }
}
