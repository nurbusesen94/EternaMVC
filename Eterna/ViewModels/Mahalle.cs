using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Mahalle")]
    public class Mahalle
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string MahalleAd { get; set; }
        public int IlceID { get; set; }
        public Ilce Ilce { get; set; }
    }
}