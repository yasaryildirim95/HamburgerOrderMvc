using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderViewModel
{
    public class OrderViewModel
    {
        public string Adress { get; set; }
        public int TotalPrice { get; set; }
        public string MenuSize { get; set; } 
        public string AppUserId { get; set; }
        public string MenuId { get; set; }

    }
}
