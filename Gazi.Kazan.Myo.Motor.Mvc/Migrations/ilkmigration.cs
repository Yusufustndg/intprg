using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace Gazi.Kazan.Myo.Motor.Mvc.Migrations
{
    public partial class ilkmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAdmin",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    KullanıcıAdı = c.String(maxLength: 50, unicode: false),
                    Sifre = c.String(maxLength: 50, unicode: false),
                    Eposta = c.String(maxLength: 50, unicode: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.tblOzellikler",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Marka = c.String(maxLength: 50, unicode: false),
                    Model = c.String(maxLength: 50, unicode: false),
                    Yakıt = c.String(maxLength: 50, unicode: false),
                    Vıtes = c.String(maxLength: 50, unicode: false),
                    KasaTıpı = c.String(maxLength: 50, unicode: false),
                    Yılı = c.Int(nullable: false),
                    Beygir = c.Int(nullable: false),
                    Tork = c.Int(nullable: false),
                    Hacim = c.Int(nullable: false),
                    Cekısturu = c.String(maxLength: 50, unicode: false),
                    Renk = c.String(maxLength: 50, unicode: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.tblOzellikler");
            DropTable("dbo.tblAdmin");
        }
    }
}