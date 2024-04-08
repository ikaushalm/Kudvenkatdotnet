using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pipeline.Controller
{
    public class HomeController
    {
        private IEmployee _employee;

        public HomeController(IEmployee employee)
        {
            _employee = employee;
        }

        public string index() {
            return _employee.getEmployee(1).Name;

        }
        public JsonResult Details()
        {
            return Json(_employee.getEmployee(1));

        }


    }
}
