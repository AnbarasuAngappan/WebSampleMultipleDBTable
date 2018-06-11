using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSampleMultipleDBTable.Models;

namespace WebSampleMultipleDBTable.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details(string ID)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.dbSetemployee.Single(Emp => Emp.EmployeeID == ID);
            return View(employee);
        }

        public ActionResult HyperDetails(string departmentID)
        {
            //EmployeeContext employeecontext = new EmployeeContext();
            //IList<Employee> employee = employeecontext.dbSetemployee.ToList();
            //return View(employee);

            EmployeeContext employeecontext = new EmployeeContext();
            IList<Employee> employee = employeecontext.dbSetemployee.Where(EmpDepID => EmpDepID.DepartmentID == departmentID).ToList();
            return View(employee);

        }
    }
}