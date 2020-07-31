using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class ZMemUclass
    {
        public int Lsh { get; set; }
        public int? Uid { get; set; }
        public string Ucode { get; set; }
        public string Udate { get; set; }
        public string Udept { get; set; }
        public string Uname { get; set; }
        public string TimeName { get; set; }
        public string OnTime { get; set; }
        public string OffTime { get; set; }
        public string Sontime { get; set; }
        public string Sofftime { get; set; }
        public string Eontime { get; set; }
        public string Eofftime { get; set; }
        public int? Latetime { get; set; }
        public int? Earlytime { get; set; }
        public bool OnFlag { get; set; }
        public bool OffFlag { get; set; }
        public decimal? Workday { get; set; }
        public int? WorkLong { get; set; }
        public string Aontime { get; set; }
        public string Aofftime { get; set; }
        public string Tlate { get; set; }
        public string Tearly { get; set; }
        public string Tadd { get; set; }
        public bool IsNoIn { get; set; }
        public bool IsNoOut { get; set; }
        public bool IsNoWork { get; set; }
        public bool IsFreeTime { get; set; }
        public bool IsOverTime { get; set; }
        public string Memo { get; set; }
        public string MemoTime { get; set; }
        public int? AbnorFlag { get; set; }
        public string Aontime2 { get; set; }
        public string Aofftime2 { get; set; }
        public string Aworktime { get; set; }
        public string Uworktime { get; set; }
        public string Uworkname { get; set; }
        public bool Checked { get; set; }
    }
}
