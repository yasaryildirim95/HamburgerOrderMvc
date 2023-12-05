using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos
{
    public class MenuCreateDto
    {
        public string Name { get; set; }
        public DataStatus DataStatusEnum { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public int PriceForMedium { get; set; }
        
    }
}
