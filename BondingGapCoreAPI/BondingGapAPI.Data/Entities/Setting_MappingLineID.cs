using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("Setting_MappingLineID")]
    public class Setting_MappingLineID
    {
        public int ID { get; set; }
        public string LineID { get; set; }
        public string MappingLineID { get; set; }
    }
}
