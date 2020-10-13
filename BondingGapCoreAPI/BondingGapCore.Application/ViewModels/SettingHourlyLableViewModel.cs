using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Application.ViewModels
{
    public class SettingHourlyLableViewModel
    {
        public int? label { get; set; }
        public DateTime? start { get; set; }
        public DateTime? end { get; set; }

        public string displayStart { get; set; }
        public string displayEnd { get; set; }
        public int option { get; set; }
    }
}
