using System.Collections.Generic;
using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreMvc2.Introduction.Model
{
    class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}