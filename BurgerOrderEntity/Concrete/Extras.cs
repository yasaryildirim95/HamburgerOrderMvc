using BurgerOrderEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class Extras : BaseEntity
    {
        public Extras()
        {
            Id = Guid.NewGuid().ToString();
        }
        public int Price { get; set; }

        //Navigation Props
        public Menu Menu { get; set; }
        public string MenuID { get; set; }
    }
}
