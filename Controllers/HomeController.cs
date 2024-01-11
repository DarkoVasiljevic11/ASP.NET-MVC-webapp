using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UpisForme()
        {
            return View();
        }
            [HttpPost]
            public ViewResult UpisForme(Forma ispis){
                return View("ispis", ispis);
            }
        
    }

}
