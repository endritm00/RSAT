using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class Holiday
    {
        public int Holidayid { get; set; }
        public string Name { get; set; }
        public DateTime Bdate { get; set; }
        public short Days { get; set; }
    }
}
