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
              .HasOne(m => m.Substance)
              .WithOne(s => s.Menu)
              .HasForeignKey<Substance>(s => s.MenuId);

            mb.Entity<Substance>()
                .HasData(new Substance { Id= "1",Name = "WhooperSubstance",Domates = true, Ketçap=true,Marul=true,Turşu=true});

            mb.Entity<Menu>()
                .HasData(new Menu { Name = "Whooper", Description = "Izgara ateeşinde muazzam whohoper köftesi patates ve içecekle servis edilir.", PriceForMedium = 100,SubstanceId = "1"});



            base.OnModelCreating(mb);
        }
    }
}
