using BurgerOrderBLL.Extension;
using BurgerOrderDAL.Abstract;
using BurgerOrderDAL.Context;
using BurgerOrderDAL.UnitOfWork;
using BurgerOrderEntity.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BurgerOrderMVC
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);



			// Add services to the container.
			builder.Services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("AlpCon"));
			});

			builder.Services
	        .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	         .AddCookie(x =>
	         {
		      x.Cookie.Name = "BenimUygulamam";
		      x.ExpireTimeSpan = TimeSpan.FromMinutes(20);
		      x.SlidingExpiration = true;
		      //x.LoginPath = "/home/privacy";

	         });
			builder.Services.AddIdentity<AppUser, AppRole>(options =>
			{
				options.SignIn.RequireConfirmedAccount = false;
				options.User.RequireUniqueEmail = true;
				
			})
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders();
			builder.Services.AddScoped<IUow, Uow>();
			builder.Services.AddBLDepencies();
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}