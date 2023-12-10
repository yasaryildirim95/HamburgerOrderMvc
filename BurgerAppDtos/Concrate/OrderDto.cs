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
        public string Name { get; set; }
        public string Id { get; set; }
        [Required(ErrorMessage ="Adres alanı boş bırakılamaz."),StringLength(200,MinimumLength =5,ErrorMessage ="Adres 5 ile 200 karekter arasında olmalıdır.")]

        public string Adress { get; set; }
        public string AppUserId { get; set; }
     
        public decimal TotalPrice { get; set; }
        public string ProductSizeId { get; set; }
        [Required(ErrorMessage ="Miktar seçmek zorundasınız."),Range(1,20,ErrorMessage ="En az 1 en fazla 20 sipariş verebilirsiniz.")]
        public int Amount { get; set; }
        public bool Domates { get; set; }
        public bool Marul { get; set; }
        public bool Sogan { get; set; }
        public bool Tursu { get; set; }
        public bool Mayonez { get; set; }
        public bool Ketcap { get; set; }
        public string MenuId { get; set; }

        public List<string> Extras { get; set; }
    }
}
