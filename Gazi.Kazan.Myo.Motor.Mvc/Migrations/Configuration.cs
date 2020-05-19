using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace Gazi.Kazan.Myo.Motor.Mvc.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Gazi.Kazan.Myo.Motor.Mvc.DAL.MotorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Gazi.Kazan.Myo.Motor.Mvc.DAL.MotorContext context)
        {
            
        }
    }
}