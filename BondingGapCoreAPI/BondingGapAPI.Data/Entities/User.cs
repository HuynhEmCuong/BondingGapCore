using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("User")]
    public class User
    {
        public int ID { get; set; }
        public string LineID { get; set; }
        public string Password { get; set; }
    }
}
