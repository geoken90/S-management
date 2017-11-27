using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    [RoutePrefix("Student")]
    public class StudentController : Controller
    {
        [Route("StudentIndex")]
        [HttpGet]
        public ActionResult StudentIndex()
        {
            return View();
        }
    }
}