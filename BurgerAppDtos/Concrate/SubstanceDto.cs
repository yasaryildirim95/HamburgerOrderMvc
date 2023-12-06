using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class SubstanceDto : IDTO
    {
        public string Id { get; set; }

        public bool Marul { get; set; }

        public bool Turşu { get; set; }

        public bool Ketçap { get; set; }

        public bool Mayonez { get; set; }

        public bool Soğan { get; set; }

        public bool Domates { get; set; }
    }
}
