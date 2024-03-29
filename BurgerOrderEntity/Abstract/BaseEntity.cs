﻿using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DataStatus DataStatusEnum { get; set; } = DataStatus.Active;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
