using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSampleMultipleDBTable.Models
{
   [Table("[Departmenttable]")]
    public class Department
    {
        [Required(ErrorMessage = "Department ID required")]
        [Display(Name = "Department ID")]
        public string DepartmentID { get; set; }

        [Required(ErrorMessage = "Department Name required")]
        [Display(Name = "Deprtment Name")]
        public string DeprtmentName { get; set; }
        
        [Display(Name = "User Name")]
        public List<Employee> employees { get; set; }
    }
}