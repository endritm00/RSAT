using NovusConsulting.Api.ViewModels;
using RSAT.Api.Data.Entities;
using System.Collections.Generic;

namespace RSAT.Api.Data.ViewModels
{
    public class ProfileViewModel : LayoutViewModel
    {
       public ProfileViewModel()
        {

        }

        public List<Employee> EmployeeCollection { get; internal set; }
    }
}
