using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderEntity.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DataStatus DataStatusEnum { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
