using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("RecordDetail")]
    public class RecordDetail
    {
        public RecordDetail() { }
        public RecordDetail(int iD, string leftRight, string attachment_Color, string worker_ID_Number_Attachment, string position_Code, string defect, string defect2, string defect3)
        {
            ID = iD;
            LeftRight = leftRight;
            Attachment_Color = attachment_Color;
            Worker_ID_Number_Attachment = worker_ID_Number_Attachment;
            Position_Code = position_Code;
            Defect = defect;
            Defect2 = defect2;
            Defect3 = defect3;

        }

        public int ID { get; set; }
        public string LeftRight { get; set; }
        public string Attachment_Color { get; set; }
        public string Worker_ID_Number_Attachment { get; set; }
        public string Position_Code { get; set; }
        public string Defect { get; set; }
        public string Defect2 { get; set; }
        public string Defect3 { get; set; }
        public int RecordID { get; set; }
    }
}
