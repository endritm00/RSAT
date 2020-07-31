using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSAT.Api.Data.Proxy
{
    public partial class Task : IDisposable
    {
        public Task()
        {
            this.List = new List<Task>();
        }
        [Key]
        public int ID { get; set; }

        public string Department { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public List<Task> List { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
