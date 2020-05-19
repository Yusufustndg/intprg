using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Motor.Mvc.Models.ViewModel
{
    public class OgrenciViewModel
    {
        public MotorModel Ogr { get; set; }
        public IEnumerable<MotorModel> Ogrenciler { get; set; }
    }
}
