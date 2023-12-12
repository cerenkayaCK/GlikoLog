using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Context
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Egzersiz> Egzersizler { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<IletisimBilgi> IletisimBilgileri { get; set; }
        public DbSet<SaglikBilgisi> SaglikBilgileri { get; set; }
        public DbSet<BesinDegeri> BesinDegerleri { get; set; }
        public DbSet<SuIcmeBilgisi> SuIcmeBilgileri { get; set; }
        public DbSet<KullaniciYemekOgun> KullaniciYemekleri { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GlikoLogDb;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=30");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici { Id = 1, Ad = "admin", Soyad = "admin", Boy = 0, Yas = 0, Cinsiyet = 0, Kilo = 0, Email = "admin@bilgeadamboost.com", Sifre = "admin", KullaniciTuru = 0, });

            modelBuilder.Entity<KullaniciYemekOgun>()

                 .HasKey(ky => ky.Id); // Sadece Id özelliği birincil anahtar olarak yeterli

            modelBuilder.Entity<KullaniciYemekOgun>()

                .HasOne(ky => ky.Kullanici)

                .WithMany(k => k.KullaniciYemekleri)

                .HasForeignKey(ky => ky.KullaniciId);

            modelBuilder.Entity<KullaniciYemekOgun>()

                .HasOne(ky => ky.Yemek)

                .WithMany(y => y.KullaniciYemekleri)

                .HasForeignKey(ky => ky.YemekId);

            modelBuilder.Entity<KullaniciYemekOgun>()

                .HasOne(ky => ky.Ogun)

                .WithMany(o => o.KullaniciYemekleri)

                .HasForeignKey(ky => ky.OgunId);


            modelBuilder.Entity<Kullanici>() // email unique olsun.
           .HasIndex(k => k.Email)
           .IsUnique();


            modelBuilder.Entity<KullaniciEgzersizler>()
                .HasKey(h => h.Id);
            modelBuilder.Entity<KullaniciEgzersizler>()

             .HasOne(ky => ky.kullanici)

             .WithMany(k => k.KullaniciEgzersizler)

             .HasForeignKey(ky => ky.kullaniciId);

            modelBuilder.Entity<KullaniciEgzersizler>()

                .HasOne(ky => ky.Egzersiz)

                .WithMany(y => y.KullaniciEgzersizler)

                .HasForeignKey(ky => ky.EgzersizId);

        }


    }

}

