using Gazi.Kazan.Myo.Motor.Mvc.Models.Result;
using Gazi.Kazan.Myo.Motor.Mvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Gazi.Kazan.Myo.Motor.Mvc.Models.AdminModel;

namespace Gazi.Kazan.Myo.Motor.Mvc.DAL
{
    public class AdminDAL
    {
        public static rAdminmodel Getir(Adminmodel admin)
        {
            MotorContext ctx = new MotorContext();

            var sorgu = from a in ctx.Admins
                        where a.KullanıcıAdı == admin.KullanıcıAdı && a.Sifre == admin.Sifre
                        select new rAdminmodel
                        {
                            KullanıcıAdı = a.KullanıcıAdı,
                            Sifre = a.Sifre,
                            Eposta = a.Eposta,
                            Id = a.Id
                        };

            return sorgu.FirstOrDefault();

        }
    }
}