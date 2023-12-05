using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class UserLoginDto : IDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool ısRememberMe { get; set; }
    }
}
