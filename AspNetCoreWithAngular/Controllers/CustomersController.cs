using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWithAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public List<Customer> Get()
        {
            return new List<Customer>
            {
            new Customer { Id = 1, FirstName = "Enes", LastName = "Tikici" },
            new Customer { Id = 1, FirstName = "Hamza", LastName = "Tikici" },
            new Customer { Id = 1, FirstName = "Zehra", LastName = "Tikici" },
            };
        }

    }
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}