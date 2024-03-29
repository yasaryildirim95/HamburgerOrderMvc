﻿using BurgerAppDtos.Concrate;
using BurgerOrderEntity.Concrete;
using Microsoft.AspNetCore.Identity;
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

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            //AppUser and AppRole Seed Datas

            var hasher = new PasswordHasher<AppUser>();
            
            var adminRoleID = Guid.NewGuid().ToString();

            mb.Entity<AppRole>().HasData(
                new AppRole { Id = Guid.NewGuid().ToString(), Name = "User" },
                new AppRole { Id = adminRoleID, Name = "Admin" });

            var adminUser = new AppUser
            {
                Id = Guid.NewGuid().ToString(), // Dinamik bir kullanıcı Id oluştur
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Name = "Admin",
                SurName = "Admin",
                Email = "admin@hotmail.com",
                NormalizedEmail = "ADMIN@HOTMAIL.COM"
            };

            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin123!");

            mb.Entity<AppUser>().HasData(adminUser);

            mb.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminUser.Id,
                RoleId = adminRoleID
            });


            //Menu and Extras Seed Datas

            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "1",
                    Name = "Whooper",
                    Description = "Izgara ateeşinde muazzam whohoper köftesi patates ve içecekle servis edilir.",
                    PriceForMedium = 100,
                    ImageURL = "https://cdn.yemek.com/mnresize/940/940/uploads/2022/05/hamburger-yemekcom.jpg",
                    Domates = true,
                    Marul = true
                    
                });

           

            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "2",
                    Name = "BigKing",
                    Description = "Izgara ateeşinde olmayan Kötü Hamburhger",
                    PriceForMedium = 120,
                    ImageURL = "https://cdn.yemek.com/mnresize/940/940/uploads/2022/05/hamburger-yemekcom.jpg",
                    Tursu = true,
                    Domates = true
                });

                

            mb.Entity<Menu>()
                .HasData(new Menu
                {
                    Id = "3",
                    Name = "ChikenRoyal",
                    Description = "Mikrodalgada tavuk burger",
                    PriceForMedium = 60,
                    ImageURL = "https://cdn.yemek.com/mnresize/940/940/uploads/2022/05/hamburger-yemekcom.jpg",
                    Sogan = true,
                    Domates = true
                });

           

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "1", Name = "Small", PriceMultiplier = (decimal)0.9 });

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "2", Name = "Medium", PriceMultiplier = (decimal)1 });

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "3", Name = "Large", PriceMultiplier = (decimal)1.2 });

            mb.Entity<ProductSize>()
                .HasData(new ProductSize { Id = "4", Name = "Mega", PriceMultiplier = (decimal)1.5 });

            mb.Entity<Extra>()
                .HasData(new Extra { Id = "1", Name = "Ranch Sos", Price = 10 });

            mb.Entity<Extra>()
                .HasData(new Extra { Id = "2", Name = "Barbekü Sos", Price = 10 });

            mb.Entity<Extra>()
                .HasData(new Extra { Id = "3", Name = "Ballı Hardal Sos", Price = 10 });

            mb.Entity <Extra>().HasIndex(x => x.Name).IsUnique();

            base.OnModelCreating(mb);
        }
    }
}
