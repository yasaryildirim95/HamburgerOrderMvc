using BurgerOrderEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderDAL.Abstract
{
    public interface IUow
    {
        void SaveChanges();
        IRepo<T> GetRepository<T>() where T:class,IEntity;
    }
}
