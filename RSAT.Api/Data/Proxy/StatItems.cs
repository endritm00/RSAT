using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class StatItems
    {
        public int Itemid { get; set; }
        public string ItemName { get; set; }
        public short Units { get; set; }
        public decimal MinUnit { get; set; }
        public short Srcontrol { get; set; }
        public bool? IsAddup { get; set; }
        public bool IsTimes { get; set; }
        public string Showas { get; set; }
    }
}
