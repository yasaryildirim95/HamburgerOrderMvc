﻿using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Concrete
{
    public class Menu : BaseEntity
    {
        public Menu()
        {
            Id=Guid.NewGuid().ToString();
        }
        public string Description { get; set; }
        public int PriceForMedium { get; set; }

        public string ImageURL { get; set; }

        public bool Domates { get; set; }
        public bool Marul { get; set; }
        public bool Sogan { get; set; }
        public bool Tursu { get; set; }
        public bool Mayonez { get; set; }
        public bool Ketcap { get; set; }


        //Navigation Props
        public List<Order> Orders { get; set; }



    }
}
