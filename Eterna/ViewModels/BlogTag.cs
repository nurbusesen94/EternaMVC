using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.ViewModels
{
    [Table("BlogTag")]
    public class BlogTag
    {
        [Key, Column(Order = 1)]
        public int BlogID { get; set; }

        [Key, Column(Order = 2)]
        public int TagID { get; set; }

        public Blog Blog { get; set; }
        public Tag Tag { get; set; }
    }
}