using Gazi.Kazan.Myo.Motor.Mvc.Models;
using Gazi.Kazan.Myo.Motor.Mvc.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static Gazi.Kazan.Myo.Motor.Mvc.Models.AdminModel;
using System.Web.Mvc;

namespace Gazi.Kazan.Myo.Motor.Mvc.DAL
{
    public class MotorContext:DbContext
    {
        internal object admins;

        public MotorContext():base("cstr")
        {
        }

        public DbSet<MotorModel> ozelliklers { get; set; }
        public DbSet<Adminmodel> Admins { get; set; }
        
    }
    
}