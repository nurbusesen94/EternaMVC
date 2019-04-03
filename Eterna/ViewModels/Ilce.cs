using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Ilce")]
    public class Ilce
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string IlceAd { get; set; }

        public int SehirPlaka { get; set; }
        public Sehir Sehir { get; set; }

        public ICollection<Mahalle> Mahalle { get; set; }
    }
}