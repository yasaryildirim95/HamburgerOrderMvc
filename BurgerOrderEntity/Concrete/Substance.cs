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
        public bool Marul { get; set; } = false;

        public bool Turşu { get; set; } = false;

        public bool Ketçap { get; set; } = false;

        public bool Mayonez { get; set; } = false;

        public bool Soğan { get; set; } = false;

        public bool Domates { get; set; } = false;

        //Navigation Prop
        public  Menu Menu { get; set; }
        public string MenuId { get; set; }


    }
}
