using AttributeRouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    public class EmployeeController : Controller
    {
        public List<Employee> listEmployee = new List<Employee>();
        // GET: Employee
        
         [Route("Employee/GetEmployee/{employeeId}")]
        public ActionResult GetEmployee(int employeeId)
        {
            AssignValues();
            List<Employee> employees = listEmployee.Where(x => x.EmployeeId == employeeId).ToList();
            return View(employees);
        }

        [Route("Employee/GetDepartment/{departmentId}")]
        public ActionResult GetDepartment(int departmentId)
        {
            AssignValues();
            List<Employee> deparmtent = listEmployee.Where(x => x.DepartmentId == departmentId).ToList();
            return View(deparmtent);
        }

        public void AssignValues()
        {
            listEmployee.Add(new Employee()
            {
                EmployeeId = 1001,
                EmployeeName = "Khaja",
                EmployeeDesignation = "SE",
                DateOfJoining = "22/05/2015",
                EmployeePhone = 806980474,
                EmployeeGender = "Male",
                City = "Hyderabad",
                Project = "AILabz",
                CompanyName = "ValueLabs",
                DepartmentName = "Testing",
                DepartmentId = 1700
            });

            listEmployee.Add(new Employee()
            {
                EmployeeId = 1002,
                EmployeeName = "Vijay",
                EmployeeDesignation = "S.SE",
                DateOfJoining = "10/05/2013",
                EmployeePhone = 907846532,
                EmployeeGender = "Male",
                City = "Hyderabad",
                Project = "AutomationTool",
                CompanyName = "Accenture",
                DepartmentName = "Quality Analyst",
                DepartmentId = 1701
            });

            listEmployee.Add(new Employee()
            {
                EmployeeId = 1003,
                EmployeeName = "Ganesh",
                EmployeeDesignation = "TeamLead",
                DateOfJoining = "01/10/2012",
                EmployeePhone = 798534120,
                EmployeeGender = "Male",
                City = "Bangalore",
                Project = "AzureDevOps",
                CompanyName = "Cognizant",
                DepartmentName = "Quality Analyst",
                DepartmentId = 1701
            });

            listEmployee.Add(new Employee()
            {
                EmployeeId = 1004,
                EmployeeName = "Pavan",
                EmployeeDesignation = "Manager",
                DateOfJoining = "01/10/2012",
                EmployeePhone = 798534120,
                EmployeeGender = "Male",
                City = "Bangalore",
                Project = "AzureDevOps",
                CompanyName = "Cognizant",
                DepartmentName = "Development",
                DepartmentId = 1702
            });
    }
    }
}