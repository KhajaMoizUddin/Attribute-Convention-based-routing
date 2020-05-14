using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AttributeRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            
            //routes.MapRoute(
            //    "GetEmployeeById",
            //    "Employee/GetEmployeeInfo/{employeeId}",
            //    new {Controller = "Employee", action = "GetEmployee" },
            //    new {employeeId = @"\d{4}"}

            //    );

            //routes.MapRoute(
            //    "GetEmployeeByDeptId",
            //    "Employee/GetEmployeeByDept/{departmentId}",
            //    new { Controller = "Employee", action = "GetDepartment"},
            //    new { departmentId = @"\d{4}"}
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
