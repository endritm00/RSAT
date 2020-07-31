using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class AccessGroup
    {
        public int AccessGroupid { get; set; }
        public string AccessGroupName { get; set; }
        public int? AccessTimeid1 { get; set; }
        public int? AccessTimeid2 { get; set; }
        public int? AccessTimeid3 { get; set; }
        public int? AccessTimeid4 { get; set; }
    }
}
