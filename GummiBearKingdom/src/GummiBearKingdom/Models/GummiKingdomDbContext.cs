using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiKingdomDbContext : DbContext
    {
        public GummiKingdomDbContext()
        {
        }

        public DbSet<Gummi> Gummis { get; set; }
        //public DbSet<Review> Review { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummiBearKingdom;integrated security=True");
        }


    }
}
