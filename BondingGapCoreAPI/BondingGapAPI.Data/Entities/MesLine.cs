using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
namespace bondinggapmonitoringsystem.Models
{
    [Table("MES_Line")]
    public  class MesLine
    {
        public string Factory_ID { get; set; }
        public string  Line_ID { get; set; }
        public string Line_Desc { get; set; }
        public string Line_DescZW { get; set; }
        public string Line_DescVN { get; set; }
        public string Line_Sname { get; set; }
        public DateTime Update_Time { get; set; }
        public string  Updated_By { get; set; }

        public string Line_Model { get; set; }

        public string Line_AB { get; set; }

    }
}
