using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Sorular")]
    public class Sorular
    {
        public int ID { get; set; }

        [StringLength(250), Column(TypeName = "varchar")]
        public string Soru { get; set; }

        [StringLength(250), Column(TypeName = "varchar")]
        public string Cevap { get; set; }

        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
    }
}