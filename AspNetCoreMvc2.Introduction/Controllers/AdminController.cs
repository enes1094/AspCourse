﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("save")]
        [Route("~/save")]
        public string Save()
        {
            return "Saved";
        }
        [Route("update")]
        public string Update()
        {
            return "Update";
        }
        [Route("delete/{id?}")]
        public string Delete(int id=0)
        {
            return String.Format("Update {0}",id); 
        }

    }
}