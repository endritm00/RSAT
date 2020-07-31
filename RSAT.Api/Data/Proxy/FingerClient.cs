using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class FingerClient
    {
        public int Clientid { get; set; }
        public string ClientName { get; set; }
        public short Linkmode { get; set; }
        public string Ipaddress { get; set; }
        public int? ClientNumber { get; set; }
        public int? Baudrate { get; set; }
        public int? RecStatus { get; set; }
        public int? Floorid { get; set; }
        public int? MachineType { get; set; }
        public int? DeviceType { get; set; }
        public string CommPwd { get; set; }
        public int? CommPort { get; set; }
        public string Timezone { get; set; }
    }
}
