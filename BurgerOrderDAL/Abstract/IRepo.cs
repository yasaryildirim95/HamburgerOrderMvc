using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderDAL.Abstract
{
    public interface IRepo<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> GetQueryable();
        List<T> GetAll(bool asnoTracking = true);
        List<T> GetAll(Expression<Func<T, bool>> filter);
        T? Get(Expression<Func<T, bool>> filter);
        T? Get(object id);
    }
}
