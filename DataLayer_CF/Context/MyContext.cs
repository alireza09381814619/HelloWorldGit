﻿using DataLayer_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_CF.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
