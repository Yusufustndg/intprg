using Gazi.Kazan.Myo.Motor.Mvc.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Gazi.Kazan.Myo.Motor.Mvc.Models.AdminModel;

namespace Gazi.Kazan.Myo.Motor.Mvc.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Adminmodel admin)
        {
            var sonuc = AdminBl.Getir(admin);

            if (sonuc != null && sonuc.Id > 0)
            {
                Session["Admin"] = sonuc.KullanıcıAdı;
                return Redirect("/Home/Index");
            }

            return View();
        }
    }
}