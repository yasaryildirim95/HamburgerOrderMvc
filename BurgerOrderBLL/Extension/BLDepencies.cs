﻿using Microsoft.Extensions.DependencyInjection;
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
        
        
        }
    }
}