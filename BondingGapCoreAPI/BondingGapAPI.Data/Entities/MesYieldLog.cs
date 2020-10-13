using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bondinggapmonitoringsystem.Models
{
    [Table("MesYieldLog")]
    public  class MesYieldLog
    {
        public decimal RecKey { get; set; }
        public string FactoryId { get; set; }
        public string DeptId { get; set; }
        public string UserId { get; set; }
        public string CycleNo { get; set; }
        public string SizeCode { get; set; }
        public int? YieldQty { get; set; }
        public DateTime? DaqTime { get; set; }
        public short? TimeBucket { get; set; }
        public string MoNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Seq { get; set; }
    }
}
