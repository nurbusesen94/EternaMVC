using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Sehir")]
    public class Sehir
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SehirPlaka { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string SehirAd { get; set; }

        public ICollection<Ilce> Ilce { get; set; }



    }
}