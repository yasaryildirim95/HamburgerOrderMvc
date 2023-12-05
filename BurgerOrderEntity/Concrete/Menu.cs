using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class Menu : BaseEntity
    {
        public Menu()
        {
            Id=Guid.NewGuid().ToString();
        }
        public string Description { get; set; }
        public int PriceForMedium { get; set; }

        //Navigation Props
        public List<Order> Orders { get; set; }
        public List<Extras> Extras { get; set; }


        public Substance Substance { get; set; }
        public string SubstanceId { get; set; }


    }
}
