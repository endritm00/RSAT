using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class MemStat
    {
        public int Lsh { get; set; }
        public string Userid { get; set; }
        public string Udept { get; set; }
        public string Uname { get; set; }
        public float Normal { get; set; }
        public float Actual { get; set; }
        public float Latetime { get; set; }
        public float Earlytime { get; set; }
        public float Absenttime { get; set; }
        public float Overtime { get; set; }
        public int Noin { get; set; }
        public int Noout { get; set; }
        public float Awaytime { get; set; }
        public float Bleave { get; set; }
        public float Leave { get; set; }
        public float Freeovertime { get; set; }
        public float Worktime { get; set; }
        public float Attrate { get; set; }
    }
}
