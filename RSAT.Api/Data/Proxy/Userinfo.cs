using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class Userinfo
    {
        public int Userid { get; set; }
        public string UserCode { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Pwd { get; set; }
        public int Deptid { get; set; }
        public string Nation { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? EmployDate { get; set; }
        public string Telephone { get; set; }
        public string Duty { get; set; }
        public string NativePlace { get; set; }
        public string Idcard { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Educated { get; set; }
        public string Polity { get; set; }
        public string Specialty { get; set; }
        public bool? IsAtt { get; set; }
        public bool? Isovertime { get; set; }
        public bool? Isrest { get; set; }
        public string Remark { get; set; }
        public short? MgFlag { get; set; }
        public string CardNum { get; set; }
        public byte[] Picture { get; set; }
        public int? UserFlag { get; set; }
        public int? Groupid { get; set; }
        public int? ClassFlag { get; set; }
        public byte[] OtherInfo { get; set; }
    }
}
