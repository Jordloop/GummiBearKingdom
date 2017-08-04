using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKingdom.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public virtual Gummi Gummi{ get; set; }

    }
}
