using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class AppUser : IdentityUser
    {


        //Navigation Props
        public List<Menu> Menus { get; set; }
    }
}
