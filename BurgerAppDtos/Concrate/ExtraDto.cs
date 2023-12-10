using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class ExtraDto : IDTO
    {
        public string Id { get; set; }


        [Required(ErrorMessage ="Extra ismi girmek zorundasınız."),StringLength(45,MinimumLength =5,ErrorMessage ="İsim 5 ile 45 karekter arasında olmalıdır.")] 
        public string Name { get; set; }
        [Required(ErrorMessage ="Ücret alanı boş bırakılamaz."),Range(1,100,ErrorMessage ="Fiyat 1 TL ile 100 TL arasında olmalıdır.")]
        public int Price { get; set; }
    }
}
