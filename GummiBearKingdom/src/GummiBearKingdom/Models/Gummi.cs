using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GummiBearKingdom.Models
{
    [Table("Gummis")]
    public class Gummi
    {
        [Key]
        public int GummiId { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Flavor { get; set; }
        public int Cost { get; set; }
        public virtual ICollection<Review> Reviews{ get; set; }
    }
}
