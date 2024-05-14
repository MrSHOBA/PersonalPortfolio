using PersonalPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactForm model)
        {
            if (ModelState.IsValid)
            {

                TempData["SuccessMessage"] = "Message sent successfully!";
                return RedirectToAction("Contact");
            }
            return View(model);
        }
    }
}