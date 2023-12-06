using BurgerOrderEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class ProductSize : BaseEntity
    {
        public ProductSize()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public decimal PriceMultiplier { get; set; }
    }
}
