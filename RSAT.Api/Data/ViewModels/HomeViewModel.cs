using NovusConsulting.Api.ViewModels;
using RSAT.Api.Data.Entities;
using System.Collections.Generic;

namespace RSAT.Api.Data.ViewModels
{
    public class HomeViewModel : LayoutViewModel
    {
        public HomeViewModel()
        {
            this.EmployeeCollection = new List<Employee>();
        }
        public List<Employee> EmployeeCollection { get; set; }
        public object Localization { get; internal set; }
        public object Olap { get; internal set; }
    }
}
