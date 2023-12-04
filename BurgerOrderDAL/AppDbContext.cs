using BurgerOrderEntity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderDAL
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,string>
    {

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
              .HasForeignKey<Substance>(s => s.MenuID);


            base.OnModelCreating(mb);
        }
    }
}
