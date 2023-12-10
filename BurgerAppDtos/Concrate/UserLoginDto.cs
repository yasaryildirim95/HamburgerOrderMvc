using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class UserLoginDto : IDTO
    {
        [Required(ErrorMessage ="Email alanı boş bırakılamaz."),EmailAddress(ErrorMessage ="Email doğru formatta olmalıdır.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Şifre boş bırakılamaz.")]
        public string Password { get; set; }
        public bool IsRememberMe { get; set; }
    }
}
