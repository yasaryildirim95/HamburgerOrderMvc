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
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public bool ısRememberMe { get; set; }
    }
}
