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
        [Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string SurName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required,Phone] 
        public string PhoneNumber { get; set; }
        [Required, StringLength(100, MinimumLength = 5)]
        public string Adress { get; set; }
    }
}
