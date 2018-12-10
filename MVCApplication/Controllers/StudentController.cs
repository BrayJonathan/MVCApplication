using MVCApplication.ViewModels.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View("StudentIndex");
        }

        public ActionResult CreateStudent()
        {
            return View("AddStudent");
        }
    }
}