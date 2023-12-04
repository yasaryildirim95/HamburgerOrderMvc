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
        public string Desctipton { get; set; }
        public int PriceForMedium { get; set; }
        public ProductSize ProductSizeEnum { get; set; }

        //Navigation Props
        public AppUser AppUser { get; set; }
        public string AppUserID { get; set; }

        public Substance Substance { get; set; }
        public string SubstanceID { get; set; }

        public List<Extras> Extras { get; set; }
    }
}
