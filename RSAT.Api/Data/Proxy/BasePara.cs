using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class BasePara
    {
        public string Company { get; set; }
        public short TwoDay { get; set; }
        public bool NoClockIn { get; set; }
        public bool NoClockOut { get; set; }
        public short LateTime { get; set; }
        public short LeaveTime { get; set; }
        public bool IsoverTime { get; set; }
        public short OverTime { get; set; }
        public short WorkDayLong { get; set; }
        public decimal? WoverTime { get; set; }
        public decimal? HoverTime { get; set; }
        public decimal? FoverTime { get; set; }
        public int? OvertimeIn { get; set; }
        public bool? IsovertimeIn { get; set; }
        public bool? DeductIn { get; set; }
        public bool? DeductOut { get; set; }
        public int? MinWorkLong { get; set; }
        public int? MaxWorkLong { get; set; }
        public int? RestDays { get; set; }
        public byte[] CustomField { get; set; }
        public string Contacts { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Province { get; set; }
        public byte[] Companylogo { get; set; }
        public double? GwLeave1 { get; set; }
        public double? GwLeave2 { get; set; }
        public double? GwLeave3 { get; set; }
        public double? GrLeave1 { get; set; }
        public double? GrLeave2 { get; set; }
        public double? GrLeave3 { get; set; }
        public double? GhLeave1 { get; set; }
        public double? GhLeave2 { get; set; }
        public double? GhLeave3 { get; set; }
    }
}
