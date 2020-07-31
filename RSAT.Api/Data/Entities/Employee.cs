using NovusConsulting.Data;
using RSAT.Api.Data.Entities;
using System.Collections.Generic;

namespace RSAT.Api.Data.Entities
{
    public class Employee : BaseEntity
    {        
        public Employee()
        {
            this.HistoryOfStatuses = new List<Checkinout>();
            this.TodayCheckedStatus = new List<Checkinout>();
        }
      
        public string Name { get; set; }
        public string Department { get; set; }
        public string CardNumber { get; set; }
        public string Status { get; set; }
        public byte[] Picture { get; set; }
        public Checkinout ActualCheckinStatuse { get; set; }
        public List<Checkinout> HistoryOfStatuses { get; set; }
        public List<Checkinout> TodayCheckedStatus { get; set; }
        public int UserId { get; internal set; }

        public string UName { get; set; }
        public string UField { get; set; }

        public string UDeg { get; set; }
        //test
    }
}
