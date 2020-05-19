using System;
using Gazi.Kazan.Myo.Motor.Mvc.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Gazi.Kazan.Myo.Motor.Mvc.Models;
using Gazi.Kazan.Myo.Motor.Mvc.Models.Result;

namespace Gazi.Kazan.Myo.Motor.Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<rOzellikler> lst = OzelliklerDAL.Listele();
            return View(lst);
        }



    }
}