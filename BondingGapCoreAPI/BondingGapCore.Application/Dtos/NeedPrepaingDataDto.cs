using BondingGapAPI.Application.ViewModels;
using System.Collections.Generic;

namespace BondingGapAPI.Application.Dtos
{
    public class NeedPrepaingDataDto
    {
        public RecordDto RecordDto { get; set; }

        public List<Reason> ListReason { get; set; }
    }

    public class Reason
    {
        public string R1 { get; set; }
        public string R2 { get; set; }
        public string R3 { get; set; }
        public string Positon { get; set; }
        public string LR { get; set; }
    }

    public class RecordDto
    {
        public string C { get; set; }
        public string CO { get; set; }
        public string A { get; set; }
        public string AO { get; set; }
        public string Name { get; set; }
        public string Num { get; set; }
        public string Operator { get; set; }
        public string L { get; set; }
        public string R { get; set; }
    }
}
