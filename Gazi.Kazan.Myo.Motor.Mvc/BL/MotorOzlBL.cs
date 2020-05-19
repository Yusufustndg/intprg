using Gazi.Kazan.Myo.Motor.Mvc.Models;
using Gazi.Kazan.Myo.Motor.Mvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gazi.Kazan.Myo.Motor.Mvc.Models.Parameter;
using Gazi.Kazan.Myo.Motor.Mvc.Models.Result;

namespace Gazi.Kazan.Myo.Motor.Mvc.BL
{

    public class MotorOzlBL
    {

        public static bool Ekle(pOzellikler ozl)
        {
            try
            {
                MotorModel o = new MotorModel();
                o.Marka = ozl.Marka;
                o.Model = ozl.Model;
                o.Yakıt = ozl.Yakıt;
                o.Vıtes = ozl.Vıtes;
                o.KasaTıpı = ozl.KasaTıpı;
                o.Yılı = ozl.Yılı;
                o.Beygir = ozl.Beygir;
                o.Tork = ozl.Tork;
                o.Hacim = ozl.Hacim;
                o.Cekısturu = ozl.Cekısturu;
                o.Renk = ozl.Renk;

                return OzelliklerDAL.Ekle(o);
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
                return OzelliklerDAL.Sil(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool Guncelle(MotorModel o)
        {
            try
            {
                return OzelliklerDAL.Guncelle(o);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<rOzellikler> Listele()
        {
            try
            {
                return OzelliklerDAL.Listele();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MotorModel Getir(int Id)
        {
            try
            {
                return OzelliklerDAL.Getir(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }


}