using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class Dept
    {
        public int Deptid { get; set; }
        public string DeptName { get; set; }
        public int SupDeptid { get; set; }
    }
}
