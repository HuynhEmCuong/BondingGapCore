using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("Setting_Count_Total_Pairs_Time_Range")]
    public class Setting_Count_Total_Pairs_Time_Range
    {
        public int ID { get; set; }
        public string Start_Hour { get; set; }
        public string Start_Minute { get; set; }
        public string Start_Second { get; set; }
        public string End_Hour { get; set; }
        public string End_Minute { get; set; }
        public string End_Second { get; set; }
    }
}
