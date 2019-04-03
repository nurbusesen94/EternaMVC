using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Blog")]
    public class Blog
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string Title { get; set; }

        [StringLength(250), Column(TypeName = "varchar")]
        public string Write { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string Writer { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual ICollection<BlogTag> BlogTag { get; set; }
    }
}