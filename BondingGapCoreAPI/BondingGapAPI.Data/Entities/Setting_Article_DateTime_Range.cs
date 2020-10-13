using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("Setting_Article_DateTime_Range")]
    public class Setting_Article_DateTime_Range
    {
        public int ID { get; set; }
        public string Before_3_Days { get; set; }
        public string After_3_Days { get; set; }
    }
}
