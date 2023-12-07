using BurgerAppDtos.Base;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class OrderDto :IDTO
    {
        [Required,StringLength(100,MinimumLength =5)]
        public string Adress { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        public string ProductSizeId { get; set; }
        [Required,Range(1,20)]
        public int Amount { get; set; }
        public bool Domates { get; set; }
        public bool Marul { get; set; }
        public bool Sogan { get; set; }
        public bool Tursu { get; set; }
        public bool Mayonez { get; set; }
        public bool Ketcap { get; set; }
        public string MenuId { get; set; }

        public List<Extras> Extras { get; set; }
    }
}
