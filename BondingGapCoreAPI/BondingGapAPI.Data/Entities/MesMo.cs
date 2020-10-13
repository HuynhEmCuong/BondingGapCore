using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bondinggapmonitoringsystem.Models
{
    [Table("MES_Mo")]
    public  class MesMo
    {
        public string Factory_Id { get; set; }
        public string Line_Id { get; set; }
        public string Line_Id_Asy { get; set; }
        public string Line_Id_Stf { get; set; }
        public string Dept_Id { get; set; }
        public string Dept_Id_Stc { get; set; }
        public string Dept_Id_Stf { get; set; }
        public string Mo_No { get; set; }
        public string Mo_Seq { get; set; }
        public string Cycle_No { get; set; }
        public string Style_No { get; set; }
        public string Style_Name { get; set; }
        public string Color_No { get; set; }
        public int? Plan_Qty { get; set; }
        public int? Utn_Yield_Qty { get; set; }
        public int? Utn_Yield_Qty_Stc { get; set; }
        public int? Utn_Yield_Qty_Stf { get; set; }
        public int? Utn_Forward_Qty_Stf { get; set; }
        public DateTime? Plan_Start_Asy { get; set; }
        //public DateTime? PlanEndAsy { get; set; }
        //public DateTime? PlanStartStf { get; set; }
        //public DateTime? PlanEndStf { get; set; }
        //public DateTime? PlanStartStc { get; set; }
        //public DateTime? PlanEndStc { get; set; }
        //public DateTime? PlanStartCut { get; set; }
        //public DateTime? PlanEndCut { get; set; }
        //public DateTime? ActStartAsy { get; set; }
        //public DateTime? ActEndAsy { get; set; }
        //public DateTime? ActStartStf { get; set; }
        //public DateTime? ActEndStf { get; set; }
        //public DateTime? ActStartStc { get; set; }
        //public DateTime? ActEndStc { get; set; }
        //public DateTime? ActStartCut { get; set; }
        //public DateTime? ActEndCut { get; set; }
        //public string Destination { get; set; }
        //public DateTime? ComfirmDate { get; set; }
        //public string ProdSeason { get; set; }
        //public string TopModel { get; set; }
        //public DateTime? UpdateTime { get; set; }
        //public string UpdatedBy { get; set; }
        //public int? UtnForwardQtyStc { get; set; }
    }
}
