using BurgerOrderEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class Substance : BaseEntity
    {
        public Substance()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name  { get; set; }
        public Menu Menu { get; set; }
        public string MenuId { get; set; }

    }
}
