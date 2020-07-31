using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class Checkinout
    {
        public int Logid { get; set; }
        public int Userid { get; set; }
        public DateTime CheckTime { get; set; }
        public int CheckType { get; set; }
        public int? Sensorid { get; set; }
        public int? WorkType { get; set; }
        public int? AttFlag { get; set; }
        public bool? Checked { get; set; }
        public bool? Exported { get; set; }
        public bool? OpenDoorFlag { get; set; }
    }
}
