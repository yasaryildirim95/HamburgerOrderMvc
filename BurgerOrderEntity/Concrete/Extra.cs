using BurgerOrderEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class Extra : BaseEntity
    {
        public Extra()
        {
            Id = Guid.NewGuid().ToString();
        }
        
        public int Price { get; set; }

    }
}
