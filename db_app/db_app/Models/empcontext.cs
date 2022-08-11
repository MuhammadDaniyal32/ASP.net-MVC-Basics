using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace db_app.Models
{
    public class empContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}