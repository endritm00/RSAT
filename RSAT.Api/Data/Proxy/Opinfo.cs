using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class Opinfo
    {
        public int Opid { get; set; }
        public string Opname { get; set; }
        public string Oppwd { get; set; }
        public int? OpgroupId { get; set; }
    }
}
