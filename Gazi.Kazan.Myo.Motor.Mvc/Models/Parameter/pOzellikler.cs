using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Motor.Mvc.Models.Parameter
{
    public class pOzellikler
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Yakıt { get; set; }
        public string Vıtes { get; set; }
        public string KasaTıpı { get; set; }
        public int Yılı { get; set; }

        public int Beygir { get; set; }
        public int Tork { get; set; }
        public int Hacim { get; set; }
        public string Cekısturu { get; set; }
        public string Renk { get; set; }
    }
}