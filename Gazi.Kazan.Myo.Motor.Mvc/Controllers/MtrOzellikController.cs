using Gazi.Kazan.Myo.Motor.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Gazi.Kazan.Myo.Motor.Mvc.BL;
using Gazi.Kazan.Myo.Motor.Mvc.Models.Parameter;
using Gazi.Kazan.Myo.Motor.Mvc.Models.Result;

namespace Gazi.Kazan.Myo.Motor.Mvc.Controllers
{
    public class MtrOzellikController : Controller
    {

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(pOzellikler p)
        {

            var sonuc = MotorOzlBL.Ekle(p);


            if (sonuc)
                return Redirect("/Home/Index");

            return View();
        }

        public ActionResult Sil(int? Id)
        {

            MotorOzlBL.Sil(Convert.ToInt32(Id));

            return Redirect("/Home/Index");
        }

        public ActionResult Guncelle(int Id)
        {
            var sonuc = MotorOzlBL.Getir(Id);

            return View(sonuc);
        }

        [HttpPost]
        public ActionResult Guncelle(MotorModel o, int? Guncelleme = 0)
        {



            MotorOzlBL.Guncelle(o);

            return Redirect("/Home/Index");
        }
    }
}