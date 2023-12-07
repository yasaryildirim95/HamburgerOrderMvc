using BurgerAppDtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class ExtrasDto : IDTO
    {
        [Required,StringLength(45,MinimumLength =5)] 

        public string Name { get; set; }
        [Required,Range(1,100)]
        public int Price { get; set; }
    }
}
