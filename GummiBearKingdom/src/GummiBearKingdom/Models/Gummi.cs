using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKingdom.Models
{
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
