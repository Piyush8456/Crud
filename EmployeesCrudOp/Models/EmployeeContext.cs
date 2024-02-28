using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeesCrudOp.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() :base("EmployeeDbConnection")
        {

        }
        public DbSet<Employees> Employee { get; set; }
    }
}