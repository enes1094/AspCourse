﻿using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc2.Introduction.Model
{
    public class SchoolContext:DbContext
    {
       
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
