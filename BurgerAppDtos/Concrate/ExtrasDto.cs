using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class ExtrasDto : IDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
