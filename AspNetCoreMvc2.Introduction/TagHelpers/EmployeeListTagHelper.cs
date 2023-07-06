using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreMvc2.Introduction.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper:TagHelper
    {
        private List<Employee> _employees;
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                new Employee{Id=1, FirstName="Enes",LastName="Tikici",CityId=6},
                new Employee{Id=2, FirstName="Hamza",LastName="Tikici",CityId=6},
                new Employee{Id=3, FirstName="Zehra",LastName="Tikici",CityId=34},
            };
        }
        private const string ListCountAttributeName = "count";
        [HtmlAttributeName(ListCountAttributeName)]
        public int ListCount { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _employees.Take(ListCount);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var employee in query)
            {
                stringBuilder.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>",employee.Id,employee.FirstName);
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());

            base.Process(context, output);
        }
    }
}
