using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsApp
{
    internal class OkulDbContext : DbContext
    {
        public DbSet<Ogrenciler> Ogrenciler { get; set; }
        public DbSet<tblDersler> Dersler { get; set; }
        public DbSet<tblOgrenciDers> OgrenciDersler { get; set; }
        public DbSet<tblSiniflar> Siniflar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-GVP20AA\SQLEXPRESS; Initial Catalog=EfObs; Integrated Security=true; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ogrenciler>().HasKey(o => o.OgrenciId);
            modelBuilder.Entity<tblDersler>().HasKey(d => d.DersId);
            modelBuilder.Entity<tblSiniflar>().HasKey(s => s.SinifId);
            modelBuilder.Entity<tblOgrenciDers>().HasKey(o => o.TempKey);
            modelBuilder.Entity<tblSiniflar>().Property(siniflar => siniflar.Kontenjan).HasColumnType("varchar").HasMaxLength(10).IsRequired();



            modelBuilder.Entity<Ogrenciler>()
              .HasOne(o => o.Sinif)
              .WithMany(s => s.Ogrenciler)
             .HasForeignKey(o => o.SinifId);


       

          



        }
    }
}
