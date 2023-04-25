using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCRUD__Scaffolding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           systemCS _context = new systemCS();

            var listofData = _context.students.ToList();
            return View(listofData);
        }

    }
}