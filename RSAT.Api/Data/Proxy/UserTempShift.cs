using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class UserTempShift
    {
        public int Userid { get; set; }
        public int Timeid { get; set; }
        public string WorkDate { get; set; }
        public bool IsOvertime { get; set; }
    }
}
