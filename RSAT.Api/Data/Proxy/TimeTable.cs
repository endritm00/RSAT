using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class TimeTable
    {
        public int Timeid { get; set; }
        public string Timename { get; set; }
        public string Intime { get; set; }
        public string Outtime { get; set; }
        public string Bintime { get; set; }
        public string Eintime { get; set; }
        public string Bouttime { get; set; }
        public string Eouttime { get; set; }
        public short Latetime { get; set; }
        public short Leavetime { get; set; }
        public decimal WorkDays { get; set; }
        public short Longtime { get; set; }
        public bool? MustIn { get; set; }
        public bool? MustOut { get; set; }
        public bool? IsFreeTime { get; set; }
        public bool? IsOverTime { get; set; }
        public string Montime { get; set; }
        public string Mofftime { get; set; }
    }
}
