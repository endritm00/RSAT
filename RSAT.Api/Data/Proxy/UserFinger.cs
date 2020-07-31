using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class UserFinger
    {
        public int Userid { get; set; }
        public int Fingerid { get; set; }
        public byte[] Fptemplate { get; set; }
    }
}
