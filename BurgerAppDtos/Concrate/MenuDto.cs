using BurgerAppDtos.Base;
using BurgerOrderEntity.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDtos.Concrate
{
    public class MenuDto : IDTO
    {
        public string Id {  get; set; }

        [Required,StringLength(50,MinimumLength =5)]
        public string Name { get; set; }

        public IFormFile ImageFile { get; set; }
        public string ImageURL { get; set; }

        public DataStatus DataStatusEnum { get; set; }
        public DateTime Created { get; set; }
        [Required,StringLength(75,MinimumLength =5)]
        public string Description { get; set; }
        [Required,Range(10,500)]
        public int PriceForMedium { get; set; }
        public bool Domates { get; set; }
        public bool Marul { get; set; }
        public bool Sogan { get; set; }
        public bool Tursu { get; set; }
        public bool Mayonez { get; set; }
        public bool Ketcap { get; set; }

    }
}
