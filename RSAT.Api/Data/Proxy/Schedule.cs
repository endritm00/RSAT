using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class Schedule
    {
        public int Schid { get; set; }
        public string Schname { get; set; }
        public short Cycles { get; set; }
        public short Units { get; set; }
        public bool? IsDefault { get; set; }
    }
}
