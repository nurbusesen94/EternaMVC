using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.ViewModels
{
    [Table("Tag")]
    public class Tag
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string TagName { get; set; }

        public virtual ICollection<BlogTag> BlogTag { get; set; }
    }
}