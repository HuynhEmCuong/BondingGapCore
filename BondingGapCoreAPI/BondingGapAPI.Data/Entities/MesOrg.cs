using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bondinggapmonitoringsystem.Models
{

    [Table("MES_Org")]
    public  class MesOrg
    {
        public string Factory_Id { get; set; }
        public string Pdc_Id { get; set; }
        public string Line_Id { get; set; }
        public string Dept_Id { get; set; }
        public string Building { get; set; }
        public int? Line_Seq { get; set; }
        public int? Status { get; set; }
        public DateTime? Update_Time { get; set; }
        public string Updated_By { get; set; }
        public string HP_Dept_ID { get; set; }
    }
}
