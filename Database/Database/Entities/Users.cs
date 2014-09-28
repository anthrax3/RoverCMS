using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Database.Entities
{
    [Table("Users")]
    public class Users
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

        public int Rank { get; set; }

        [Column("Vip_Points")]
        public int VipPoints { get; set; }

        [Column("Activity_Points")]
        public int ActivityPoints { get; set; }

        public string Figure { get; set; }

        public string Gender { get; set; }

        public string Motto { get; set; }

        public int LastOnline { get; set; }

        public bool Online { get; set; }

        [Column("Ip_Reg")]
        public bool RegistrationIp { get; set; }
    }
}
