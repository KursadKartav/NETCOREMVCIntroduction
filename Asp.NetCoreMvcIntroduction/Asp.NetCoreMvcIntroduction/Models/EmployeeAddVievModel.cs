
using Asp.NetCoreMvcIntroduction.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Asp.NetCoreMvcIntroduction
{
    public class EmployeeAddVievModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; internal set; }
    }
}