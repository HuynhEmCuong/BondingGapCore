using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("HourlyRecord")]
    public class HourlyRecord
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
        public string Worker_ID_Collect_Data { get; set; }
        public string Hourly_Good_Shoes { get; set; }
        public string Hourly_Need_Preparing { get; set; }
        public string Hourly_RFT { get; set; }
        public string TotalPairs { get; set; }
        public string Hourly_DefectPercentage { get; set; }
        public string Status { get; set; }
        public string Confirm_By { get; set; }
        public string Confirm_Date { get; set; }

        public IEnumerable<HourlyRecordInDetail> HourlyRecordInDetail { get; set; }
    }
}
