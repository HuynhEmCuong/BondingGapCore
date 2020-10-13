using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Application.ViewModels
{
    public class RecordViewModel
    {
        public int ID { get; set; }
        public string Prod_Cell { get; set; }
        public string Article_Number { get; set; }
        public string Model_Number { get; set; }
        public string Model_Name { get; set; }
        public DateTime Date_Time { get; set; } = DateTime.Now;
        public string Worker_ID_Collect_Data { get; set; }
        public string Good_Shoes { get; set; } = "0";
        public string Need_Preparing { get; set; } = "1";
        public string Hourly_Label { get; set; }
        public string Prod_Cell_Main { get; set; }
    }
}
