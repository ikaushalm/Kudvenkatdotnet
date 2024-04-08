
using DependencyInjection_mvcview.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_mvcview.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudent _studnent;

        public HomeController(IStudent student)
        {
            _studnent = student;
        }
        public string index()
        {
            return "Hi from index methods";
        }
        public ViewResult details()
        {
            return View("Insideview/details");

        }
    }
}
