
using Asp.NetCoreMvcIntroduction.Entities;
using System.Collections.Generic;

namespace Asp.NetCoreMvcIntroduction
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}