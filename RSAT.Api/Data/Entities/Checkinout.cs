using NovusConsulting.Data;
using RSAT.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSAT.Api.Data.Entities
{
    public class Checkinout : BaseEntity
    {
        public Checkinout()
        {
        }
        public int EmployeeId { get; set; }
        public string CheckStatus { get; set; }
        public DateTime CheckTime { get; set; }
        public Employee EmployeeObject { get; set; }

    }

}
