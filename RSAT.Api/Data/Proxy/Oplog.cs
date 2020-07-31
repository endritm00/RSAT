using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class Oplog
    {
        public int Logid { get; set; }
        public int Opid { get; set; }
        public DateTime Optime { get; set; }
        public string Oplog1 { get; set; }
    }
}
