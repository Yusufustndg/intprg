using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Motor.Mvc.Models
{
    public class AdminModel
    {
        [Table("tblAdmin")]
        public class Adminmodel
        {
            public int Id { get; set; }

            [Column(TypeName = "varchar")]
            [MaxLength(50)]
            public string KullanıcıAdı { get; set; }
            [Column(TypeName = "varchar")]
            [MaxLength(50)]
            public string Sifre { get; set; }
            [Column(TypeName = "varchar")]
            [MaxLength(50)]
            public string Eposta { get; set; }
        }
    }
}