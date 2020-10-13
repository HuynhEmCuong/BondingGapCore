using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("HourlyRecordInDetail")]
    public class HourlyRecordInDetail
    {
        [Key]
        public int ID { get; set; }
        public string Current_Line { get; set; }
        public string Work_For_Line { get; set; }
        public string PO { get; set; }
        public string Article_Number { get; set; }
        public string Model_Number { get; set; }
        public string Model_Name { get; set; }
        public string Hourly_Label { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string LeftRight { get; set; }
        public string Attachment_Color { get; set; }
        public string Worker_ID_Number_Attachment1 { get; set; }
        public string Worker_ID_Number_Attachment2 { get; set; }
        public string Position_Code { get; set; }
        public string Sum_By_Group_LR_Color_Position { get; set; }

        public HourlyRecord HourlyRecord { get; set; }
    }
}
