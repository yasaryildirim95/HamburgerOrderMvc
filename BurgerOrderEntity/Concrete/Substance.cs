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
        public bool Marul { get; set; }

        public bool Turşu { get; set; }

        public bool Ketçap { get; set; }

        public bool Mayonez { get; set; }

        public bool Soğan { get; set; }

        public bool Domates { get; set; }

        //Navigation Prop
        public  Menu Menu { get; set; }
        public int MenuID { get; set; }


    }
}
