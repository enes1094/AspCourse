using System.Collections.Generic;
using AspNetCoreMvc2.Introduction.Entities;

namespace AspNetCoreMvc2.Introduction.Model
{
    public class emloyeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> cities { get; set; }
    }
}