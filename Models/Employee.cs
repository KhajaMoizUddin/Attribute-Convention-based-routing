using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AttributeRouting.Models
{
    public class Employee
    {
        [DisplayName("Employee Id")]
        public int EmployeeId { get; set; }
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }
        [DisplayName("Employee Designation")]
        public string EmployeeDesignation { get; set; }
        [DisplayName("Date Of Joining")]
        public string DateOfJoining { get; set; }
        [DisplayName("Employee Phone")]
        public int EmployeePhone { get; set; }
        [DisplayName("Employee Gender")]
        public string EmployeeGender { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("Project")]
        public string Project { get; set; }
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }
        [DisplayName("Department Id")]
        public int DepartmentId { get; set; }
    }
}