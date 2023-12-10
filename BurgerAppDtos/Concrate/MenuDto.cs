using BurgerAppDtos.Base;
using BurgerOrderEntity.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class MenuDto : IDTO
    {
        public string Id {  get; set; }

        [Required(ErrorMessage ="Menü ismi boş bırakılamaz."),StringLength(50,MinimumLength =5,ErrorMessage ="Menü ismi 5 ile 50 karekter arasında olmalıdır.")]
        public string Name { get; set; }

        public IFormFile ImageFile { get; set; }
        public string ImageURL { get; set; }

        public DataStatus DataStatusEnum { get; set; }
        public DateTime Created { get; set; }
        [Required(ErrorMessage ="Açıklama alanı boş bırakılamaz."),StringLength(75,MinimumLength =5,ErrorMessage ="Açıklama 5 ile 75 karekter arasında olmalıdır.")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Fiyat alanı boş bırakılamaz."),Range(10,500,ErrorMessage ="Fiyat aralığı 10 TL ile 500 TL arasında olmalıdır.")]
        public int PriceForMedium { get; set; }
        public bool Domates { get; set; }
        public bool Marul { get; set; }
        public bool Sogan { get; set; }
        public bool Tursu { get; set; }
        public bool Mayonez { get; set; }
        public bool Ketcap { get; set; }

    }
}
