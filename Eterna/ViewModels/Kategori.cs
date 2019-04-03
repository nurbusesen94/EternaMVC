using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Kategori")]
    public class Kategori
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string Ad { get; set; }
     
        public ICollection<Sorular> Sorular { get; set; }
    }
}