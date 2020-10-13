using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("Setting_Defect_Reason")]
    public class Setting_Defect_Reason
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string ReasonEN { get; set; }
        public string ReasonCN { get; set; }
        public string ReasonVN { get; set; }
        public string ReasonMM { get; set; }
        public string ReasonIDN { get; set; }
    }
}
