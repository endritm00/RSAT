using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class WorkCode
    {
        public int WorkId { get; set; }
        public string WorkName { get; set; }
        public int? Units { get; set; }
        public decimal? MinUnit { get; set; }
        public int? Srcontrol { get; set; }
        public bool? IsAddup { get; set; }
        public bool? IsTimes { get; set; }
    }
}
