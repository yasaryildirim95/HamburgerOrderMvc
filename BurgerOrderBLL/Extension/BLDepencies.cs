using BurgerOrderBLL.Manager;
using BurgerOrderBLL.Service.Base;
using BurgerOrderBLL.Service.Contrate;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Extension
{
    public static class BLDepencies
    {
        public static void AddBLDepencies(this IServiceCollection service) 
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());



            service.AddScoped<IAccountService, AccountManager>();
            service.AddScoped<IExtrasService, ExtrasManager>();
            service.AddScoped<IMenuService, MenuManager>();
            service.AddScoped<IOrderService, OrderManager>();




        }
    }
}
