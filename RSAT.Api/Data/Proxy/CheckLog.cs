using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class CheckLog
    {
        public int Logid { get; set; }
        public int Userid { get; set; }
        public DateTime Checktime { get; set; }
        public int? Checktype { get; set; }
        public int? Sensorid { get; set; }
        public int? WorkType { get; set; }
        public int? AttFlag { get; set; }
        public short? Opflag { get; set; }
        public string Whys { get; set; }
        public string Opname { get; set; }
        public DateTime Dtime { get; set; }
    }
}
