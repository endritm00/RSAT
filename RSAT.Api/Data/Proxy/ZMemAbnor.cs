using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class ZMemAbnor
    {
        public int Lsh { get; set; }
        public int? Uid { get; set; }
        public string Ucode { get; set; }
        public string Udept { get; set; }
        public string Uname { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public string AbnorShow { get; set; }
        public string TimeLong { get; set; }
        public decimal? Workday { get; set; }
        public string Worklong { get; set; }
        public string Remark { get; set; }
    }
}
