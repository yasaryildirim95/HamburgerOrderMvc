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
                    
                });

           

            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "2",
                    Name = "BigKing",
                    Description = "Izgara ateeşinde olmayan Kötü Hamburhger",
                    PriceForMedium = 120,
                    
                });

                

            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "3",
                    Name = "ChikenRoyal",
                    Description = "Mikrodalgada tavuk burger",
                    PriceForMedium = 60,
                    
                });

           

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "1", Name = "Small", PriceMultiplier = (decimal)0.9 });

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "2", Name = "Medium", PriceMultiplier = (decimal)1 });

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "3", Name = "Large", PriceMultiplier = (decimal)1.2 });

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "4", Name = "Mega", PriceMultiplier = (decimal)1.5 });

            mb.Entity<Extras>()
                .HasData(new Extras { Id = "1", Name = "Ranch Sos", Price = 10 });


            mb.Entity<Substance>().HasOne(s => s.Menu).WithMany(s => s.Substances).HasForeignKey(x => x.MenuId);

            base.OnModelCreating(mb);
        }
    }
}
