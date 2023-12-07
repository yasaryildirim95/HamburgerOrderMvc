using BurgerAppDtos.Base;
using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class MenuDto : IDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DataStatus DataStatusEnum { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public int PriceForMedium { get; set; }
        public bool Domates { get; set; }
        public bool Marul { get; set; }
        public bool Sogan { get; set; }
        public bool Tursu { get; set; }
        public bool Mayonez { get; set; }
        public bool Ketcap { get; set; }

    }
}
