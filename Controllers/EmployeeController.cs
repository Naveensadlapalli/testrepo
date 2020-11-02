using RegistrationPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationPage.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        SystemTestEntities obj = new SystemTestEntities();
        public ActionResult Index()
        {
            IEnumerable<Models.Registration> ie = obj.Registrations.ToList();
            TempData["ie"] = ie;
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Registration e1)
        {
            obj.Registrations.Add(e1);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}