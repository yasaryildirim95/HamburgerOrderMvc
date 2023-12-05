using BurgerOrderDAL.Context;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderDAL.Repos
{
    public class MenuRepo : GenericRepo<Menu>
    {
        public MenuRepo(AppDbContext appDbContext) : base(appDbContext) 
        {
            
        }

        public bool CreateMenu()
        {
            return true;
        }
        
    }
}
