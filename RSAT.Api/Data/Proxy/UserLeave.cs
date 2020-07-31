using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class UserLeave
    {
        public int Lsh { get; set; }
        public int Userid { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int LeaveClassid { get; set; }
        public string Whys { get; set; }
        public bool? Checked { get; set; }
    }
}
