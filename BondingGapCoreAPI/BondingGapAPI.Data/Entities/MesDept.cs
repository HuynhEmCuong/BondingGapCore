using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bondinggapmonitoringsystem.Models
{
    [Table("MES_Dept")]
    public  class MesDept
    {
        public string Factory_Id { get; set; }
        public string Dept_Id { get; set; }
        public string Dept_Type { get; set; }
        public string Dept_Desc { get; set; }
        public string Dept_DescZw { get; set; }
        public string Dept_DescVn { get; set; }
        public string Dept_Sname { get; set; }
        public string Ps_Id { get; set; }
        public string Lunch_Order { get; set; }
        public string Work_Center { get; set; }
        public string Need_Bulletin { get; set; }
        public string Need_Camera { get; set; }
        public string Need_Andon { get; set; }
        public DateTime? Update_Time { get; set; }
        public string Updated_By { get; set; }
    }
}
