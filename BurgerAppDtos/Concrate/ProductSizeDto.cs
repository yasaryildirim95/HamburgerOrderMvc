﻿using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class ProductSizeDto : IDTO
    {
        public string Id { get; set; }
        public decimal PriceMultiplier { get; set; }

    }
}
