using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class UserRegisterDto
    {

        [Required(ErrorMessage ="İsim alanı boş bırakılamaz."), StringLength(50, MinimumLength = 3,ErrorMessage ="İsim 3 ile 50 karekter arasında olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Soyisim alanı boş bırakılamaz."), StringLength(50, MinimumLength = 3,ErrorMessage ="Soyisim 3 ile 50 karekter arasında olmalıdır.")]
        public string SurName { get; set; }
        [Required(ErrorMessage ="Kullanıcı alanı boş bırakılamaz."), StringLength(50, MinimumLength = 3,ErrorMessage ="Kullanıcı ismi 3 ile 50 karekter arasında olmalıdır.")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Email alanı boş bırakılamaz."),EmailAddress(ErrorMessage ="Email doğru formatta yazılmalıdır.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Şifre boş bırakılamaz."),MaxLength(20,ErrorMessage ="Şifre 20 karekteri geçmemelidir.")]
        public string Password { get; set; }

    }
}
