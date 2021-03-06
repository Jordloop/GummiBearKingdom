﻿using System;
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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        //remove "@" and add in its place \\
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummiBearKingdom;integrated security=True");
        }

        public GummiKingdomDbContext(DbContextOptions<GummiKingdomDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
