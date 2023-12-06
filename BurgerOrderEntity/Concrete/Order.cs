using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class Order :  BaseEntity
    {
        public string Adress { get; set; }
        public decimal TotalPrice { get; set; }

        public ProductSize ProductSize { get; set; }
        public string ProductSizeId { get; set; }
        public int Amount { get; set; }

        //Navigation Props
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }


        public Menu Menu { get; set; }
        public string MenuId { get; set; }

    }
}
