using BurgerAppDtos.Concrate;
using BurgerOrderEntity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderDAL.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Substance> Substances { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            
            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "1",
                    Name = "Whooper",
                    Description = "Izgara ateeşinde muazzam whohoper köftesi patates ve içecekle servis edilir.",
                    PriceForMedium = 100,
                    SubstanceId = "1",
                });

            mb.Entity<Substance>()
                .HasData(new Substance
                {
                    Id = "1",
                    Name = "WhooperSubstance",
                    Domates = true,
                    Ketçap = true,
                    Marul = true,
                    Turşu = true
                });

            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "2",
                    Name = "BigKing",
                    Description = "Izgara ateeşinde olmayan Kötü Hamburhger",
                    PriceForMedium = 120,
                    SubstanceId = "2"
                });

            mb.Entity<Substance>()
                .HasData(new Substance
                {
                    Id = "2",
                    Name = "BigKingSubstance",
                    Domates = false,
                    Ketçap = true,
                    Marul = false,
                    Turşu = true
                });

            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "3",
                    Name = "ChikenRoyal",
                    Description = "Mikrodalgada tavuk burger",
                    PriceForMedium = 60,
                    SubstanceId = "3"
                });

            mb.Entity<Substance>()
                .HasData(new Substance
                {
                    Id = "3",
                    Name = "ChikenRoyalSubstance",
                    Domates = false,
                    Ketçap = true,
                    Marul = true,
                    Turşu = false
                });





            base.OnModelCreating(mb);
        }
    }
}
