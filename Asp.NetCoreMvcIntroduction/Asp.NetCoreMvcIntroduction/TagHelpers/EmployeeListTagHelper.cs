
using Asp.NetCoreMvcIntroduction.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCoreMvcIntroduction.TagHelpers
{
    [HtmlTargetElement("employee-list")] //Kendi taghelperımızı oluşturduk.
    public class EmployeeListTagHelper : TagHelper
    {
        private List<Employee> _employees;
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Emre", LastName = "Kesko", CityId = 34 },
                new Employee { Id = 2, FirstName = "Mehmet", LastName = "Kesko", CityId = 6 },
                new Employee { Id = 3, FirstName = "Keskin", LastName = "Kesko", CityId = 79 }
            };

        }
        private const string ListCountAttributeName = "count";
        [HtmlAttributeName(ListCountAttributeName)]
        public int ListCount { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; //yapacağım şeyleri divin içine yaz
            var query = _employees.Take(ListCount); //sorgu oluşturdum.
            StringBuilder stringBuilder = new StringBuilder(); //

            foreach (var employee in query)
            {
                stringBuilder.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>", employee.Id, employee.FirstName);
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}
