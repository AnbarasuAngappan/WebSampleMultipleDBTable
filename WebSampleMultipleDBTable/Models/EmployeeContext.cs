using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSampleMultipleDBTable.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> dbSetemployee { get; set; }
        public DbSet<Department> dbsetdepartments { get; set; }
    }
}