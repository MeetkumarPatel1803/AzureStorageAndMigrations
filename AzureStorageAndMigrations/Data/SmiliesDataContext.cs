using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class SmiliesDataContext : DbContext
    {
        public SmiliesDataContext(DbContextOptions<SmiliesDataContext> options)
            : base(options)
        {

        }

        public DbSet<Smiley> Smilies{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Smiley>().ToTable("Smiley");
        }
    }
}
