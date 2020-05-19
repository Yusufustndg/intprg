using Gazi.Kazan.Myo.Motor.Mvc.Models;
using Gazi.Kazan.Myo.Motor.Mvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gazi.Kazan.Myo.Motor.Mvc.Models.Result;

namespace Gazi.Kazan.Myo.Motor.Mvc.DAL
{
    public class OzelliklerDAL
    {
        public static bool Ekle(MotorModel ozl)
        {
            try
            {
                MotorContext ctx = new MotorContext();
                ctx.ozelliklers.Add(ozl);
                return ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MotorModel Getir(int Id)
        {
            MotorContext ctx = new MotorContext();
            var ozellik = ctx.ozelliklers.Where(o => o.Id == Id).FirstOrDefault();
            if (ozellik != null)
                return ozellik;

            return null;
        }
        public static List<rOzellikler> Listele()
        {
            try
            {
                MotorContext ctx = new MotorContext();

                var sorgu = from ozl in ctx.ozelliklers
                            select new rOzellikler
                            {   
                                Id = ozl.Id,
                                Marka = ozl.Marka,
                                Model = ozl.Model,
                                Yakıt = ozl.Yakıt,
                                Vıtes = ozl.Vıtes,
                                KasaTıpı = ozl.KasaTıpı,
                                Yılı = ozl.Yılı,
                                Beygir = ozl.Beygir,
                                Tork = ozl.Tork,
                                Hacim = ozl.Hacim,
                                Cekısturu = ozl.Cekısturu,
                                Renk = ozl.Renk,
                            };

                return sorgu.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Sil(int Id)
        {
            try
            {
                MotorContext ctx = new MotorContext();
                var ogr = ctx.ozelliklers.Where(o => o.Id == Id).FirstOrDefault();
                if (ogr != null)
                {
                    ctx.ozelliklers.Remove(ogr);
                    return ctx.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Guncelle(MotorModel ozl)
        {
            MotorContext ctx = new MotorContext();
            MotorModel o1 = ctx.ozelliklers.Where(o => o.Id == ozl.Id).FirstOrDefault();
            if (o1 != null)
            {
                o1.Marka = ozl.Marka;
                o1.Model = ozl.Model;
                o1.Hacim = ozl.Hacim;
                o1.Cekısturu = ozl.Cekısturu;
                o1.Beygir = ozl.Beygir;
                o1.KasaTıpı = ozl.KasaTıpı;
                o1.Renk = ozl.Renk;
                o1.Vıtes = ozl.Vıtes;
                o1.Yılı = ozl.Yılı;
                o1.Yakıt = ozl.Yakıt;

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
    }
}