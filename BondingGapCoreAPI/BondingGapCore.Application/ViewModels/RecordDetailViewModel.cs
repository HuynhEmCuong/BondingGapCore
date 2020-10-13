using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Application.ViewModels
{
    public class RecordDetailViewModel
    {
        public int ID { get; set; }
        public string LeftRight { get; set; }
        public string Attachment_Color { get; set; }
        public string Worker_ID_Number_Attachment { get; set; }
        public string Position_Code { get; set; }
        public string Defect { get; set; }
        public string Defect2 { get; set; }
        public string Defect3 { get; set; }
        public int RecordId { get; set; }
    }
}
