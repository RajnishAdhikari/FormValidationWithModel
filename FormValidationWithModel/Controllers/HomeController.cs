using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormValidationWithModel.Models;
namespace FormValidationWithModel.Controllers

{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SubmitData(Student s)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }
    }
}