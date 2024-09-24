using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PlaceInfoDbContext : DbContext
    {
        public PlaceInfoDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public virtual DbSet<Info> Infos { get; set; }

        public virtual DbSet<Place> Places { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Info>().ToTable("Infos");
            modelBuilder.Entity<Place>().ToTable("Places");                       
        }

    }
}
