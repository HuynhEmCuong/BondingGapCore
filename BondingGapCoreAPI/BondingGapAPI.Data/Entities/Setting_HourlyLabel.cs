using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("Setting_HourlyLabel")]
    public class Setting_HourlyLabel
    {
        public int ID { get; set; }
        public string Start_Hour { get; set; }
        public string Start_Minute { get; set; }
        public string Start_Second { get; set; }
        public string End_Hour { get; set; }
        public string End_Minute { get; set; }
        public string End_Second { get; set; }
        public string Hourly_Label { get; set; }
    }
}
