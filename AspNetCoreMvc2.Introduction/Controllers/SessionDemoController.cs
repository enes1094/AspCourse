using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc2.Introduction.Entities;
using AspNetCoreMvc2.Introduction.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index()
        {
            HttpContext.Session.SetInt32("age", 23);
            HttpContext.Session.SetString("name", "Enes");
            HttpContext.Session.SetObject("student",new Student { Email = "Hamzatilici@gmail.com", FirstName = "Hamza", LastName = "Tikici" });
            return "Sesion Created";
        }
        public string GetSesions()
        {
            return String.Format("Hello {0}, you are {1}. Student is {2}",HttpContext.Session.Get("name"),
                HttpContext.Session.GetInt32("age"),HttpContext.Session.GetObject<Student>("student").FirstName);
        }
    }
}