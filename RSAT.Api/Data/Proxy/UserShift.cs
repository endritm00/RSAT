using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class UserShift
    {
        public int Userid { get; set; }
        public int Schid { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
    }
}
