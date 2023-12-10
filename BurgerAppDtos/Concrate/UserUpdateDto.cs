using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class UserUpdateDto
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="İsim boş bırakılamaz."), StringLength(50, MinimumLength = 3,ErrorMessage ="İsim 3 ile 50 karekter olamlıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Soyisim boş bırakılamaz."), StringLength(50, MinimumLength = 3,ErrorMessage ="Soyisim 3 ile 50 karekter olmalıdır.")]
        public string SurName { get; set; }
        [Required(ErrorMessage ="Email alanı boş bırakılamaz."), EmailAddress(ErrorMessage ="Emaili doğru formatta giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Telofon alanı boş bırakılamaz."),Phone(ErrorMessage ="Numarıyı doğru formatta giriniz.")] 
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Adres alanı boş bırakılamaz."), StringLength(200, MinimumLength = 5,ErrorMessage ="Adres 5 ile 200 karekter arasında olmalıdır.")]
        public string Adress { get; set; }
    }
}
