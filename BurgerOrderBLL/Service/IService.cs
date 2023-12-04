using BurgerAppDtos.User;
using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Service
{
    public interface IService<T> where T : class,IEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(object id);
        T? Get(object id);
        IEnumerable<T> GetAll();
    }
}
