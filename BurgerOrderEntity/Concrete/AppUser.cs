using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class AppUser : IdentityUser,IEntity
    {
        public DataStatus DataStatusEnum { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }

        public string Name { get; set; }
        public string SurName { get; set; }

        //Navigation Props
        public List<Order> Orders { get; set; }
    }
}
