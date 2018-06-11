using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSampleMultipleDBTable.Models
{
   [Table("[Employeetable]")]
    public class Employee
    {
        [Display(Name = "ID :")]
        public string EmployeeID { get; set; }

        [Display(Name = "Employee Name :")]
        public string EmployeeName { get; set; }

        [Display(Name = "Employee Age :")]        
        public string EmployeeAge { get; set; }

        [Display(Name = "Employee Gender :")]
        public string EmployeeGender { get; set; }

        [Display(Name = "Employee City :")]
        public string EmployeeCity { get; set; }

        [Display(Name = "Employee Department ID :")]
        public string EmpDepartmentID { get; set; }

        [Display(Name = "Department ID :")]
        public string DepartmentID { get; set; }
    }
}