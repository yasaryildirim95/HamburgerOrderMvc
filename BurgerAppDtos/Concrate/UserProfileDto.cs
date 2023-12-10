using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class UserProfileDto : IDTO
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="İsim alnı boş bırakılamaz."),StringLength(50,MinimumLength =3,ErrorMessage ="İsim 3 ile 50 karekter arasında olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Soyisim alanı boş bırakılamaz."), StringLength(50, MinimumLength = 3,ErrorMessage ="Soyisim 3 ile 50 karekter arasında olmalıdır.")]
        public string SurName { get; set; }
        [Required(ErrorMessage ="Email alanı boş bırakılamaz."),EmailAddress(ErrorMessage ="Email doğru formatta yazılmalıdır.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Telofon numarası boş bırakılamaz."),Phone(ErrorMessage ="Doğru formatta giriniz.")] 
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Mevcut şifre alanı boş bırakılamaz."),MaxLength(20,ErrorMessage ="Şifre uzunluğu 20 karekteri geçmemelidir.")]
        public string CurrentPassword { get; set; }
        [Required(ErrorMessage ="Yeni şifre alanı boş bırakılamaz."),MaxLength(20,ErrorMessage = "Şifre uzunluğu 20 karekteri geçmemelidir.")]
        public string? NewPassword { get; set; }
    }
}
