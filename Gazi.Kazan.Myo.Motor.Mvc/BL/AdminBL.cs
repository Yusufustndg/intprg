using Gazi.Kazan.Myo.Motor.Mvc.DAL;
using Gazi.Kazan.Myo.Motor.Mvc.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Gazi.Kazan.Myo.Motor.Mvc.Models.AdminModel;

namespace Gazi.Kazan.Myo.Motor.Mvc.BL
{
    public class AdminBl
    {
        public bool AdminEkle(Adminmodel prs)
        {
            try
            {
                MotorContext ctx = new MotorContext();
                ctx.Admins.Add(prs);
                return ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Sil(Adminmodel adm)
        {
            try
            {
                MotorContext ctx = new MotorContext();
                ctx.Admins.Remove(adm);
                return ctx.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Guncelle(Adminmodel p, int AdmId)
        {
            try
            {
                MotorContext ctx = new MotorContext();
                Adminmodel adm = ctx.Admins.Find(AdmId);
                if (adm != null)
                {

                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Adminmodel> Listele()
        {
            try
            {
                MotorContext ctx = new MotorContext();
                List<Adminmodel> lst = ctx.Admins.ToList();

                if (lst != null)
                {
                    return lst;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static rAdminmodel Getir(Adminmodel admin)
        {
            try
            {
                return AdminDAL.Getir(admin);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}