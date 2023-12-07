using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class Order :  BaseEntity
    {
        public Order()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Adress { get; set; }
        public decimal TotalPrice { get; set; }

        public ProductSize ProductSize { get; set; }
        public string ProductSizeId { get; set; }
        public int Amount { get; set; }
        public bool Domates { get; set; }
        public bool Marul { get; set; }
        public bool Sogan { get; set; }
        public bool Tursu { get; set; }
        public bool Mayonez { get; set; }
        public bool Ketcap { get; set; }

        //Navigation Props
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }


        public Menu Menu { get; set; }
        public string MenuId { get; set; }
        [NotMapped]
        public List<string> Extras { get; set; } = new List<string>();

    }
}
