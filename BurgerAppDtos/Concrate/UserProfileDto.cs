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
        [Required,StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string SurName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Phone] 
        public string PhoneNumber { get; set; }
        [Required,MaxLength(20)]
        public string CurrentPassword { get; set; }
        [Required,MaxLength(20)]
        public string? NewPassword { get; set; }
    }
}
