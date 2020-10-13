using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bondinggapmonitoringsystem.Models
{
    [Table("Record")]
    public class Record
    {
        public Record(int iD, string prod_Cell, string pO, string article_Number, string model_Number, string model_Name, DateTime date_Time, string worker_ID_Collect_Data, string good_Shoes, string need_Preparing, string hourly_Label, string prod_Cell_Main)
        {
            ID = iD;
            Prod_Cell = prod_Cell;
            Article_Number = article_Number;
            Model_Number = model_Number;
            Model_Name = model_Name;
            Date_Time = date_Time;
            Worker_ID_Collect_Data = worker_ID_Collect_Data;
            Good_Shoes = good_Shoes;
            Need_Preparing = need_Preparing;
            Hourly_Label = hourly_Label;
            Prod_Cell_Main = prod_Cell_Main;
        }

        public int ID { get; set; }
        public string Prod_Cell { get; set; }
        public string Article_Number { get; set; }
        public string Model_Number { get; set; }
        public string Model_Name { get; set; }
        public DateTime Date_Time { get; set; }
        public string Worker_ID_Collect_Data { get; set; }
        public string Good_Shoes { get; set; }
        public string Need_Preparing { get; set; }
        public string Hourly_Label { get; set; }
        public string Prod_Cell_Main { get; set; }

        //public IEnumerable<RecordDetail> RecordDetail { get; set; }
    }
}
