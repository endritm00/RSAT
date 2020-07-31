using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class LeaveClass
    {
        public int Classid { get; set; }
        public string Classname { get; set; }
        public int ViewColor { get; set; }
        public string Showas { get; set; }
        public int? Units { get; set; }
        public decimal? MinUnit { get; set; }
        public int? Srcontrol { get; set; }
        public bool? IsAddup { get; set; }
        public bool? IsTimes { get; set; }
        public bool? IsLeave { get; set; }
    }
}
