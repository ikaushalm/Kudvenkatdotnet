using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dependency_Injection.Model;

namespace Dependency_Injection.Controllers
{
    public class HomeController:Controller
    {
        private readonly IStudent _student;

        public HomeController(IStudent student)
        {
            _student = student;

        }
        public string Index()
        {
            return "hi from action method";
        }
        public ViewResult details()
        {
            return View(_student.GetStudent(1));
        }




    }
}
