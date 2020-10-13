using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("MesDefectLog")]
    public class MesDefectLog
    {
        [Key]
        public decimal RecKey { get; set; }

        public string QC_Type { get; set; }

        public DateTime? Inspect_Time { get; set; }

        public short? Time_Bucket { get; set; }

        public string Inspector { get; set; }

        public string QC_Dept_ID { get; set; }

        public string PDC_ID { get; set; }

        public string Factory_ID { get; set; }

        public string Line_ID { get; set; }

        public string Dept_ID { get; set; }

        public string MO_No { get; set; }

        public string Def_ID { get; set; }

        public int Sample_Qty { get; set; }

        public int Def_Qty { get; set; }

        public string DefSnap_Path { get; set; }

        public DateTime? Create_Time { get; set; }
    }
}
