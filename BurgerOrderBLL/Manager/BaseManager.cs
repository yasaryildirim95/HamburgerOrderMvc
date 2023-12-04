using AutoMapper;
using BurgerAppDtos.User;
using BurgerOrderBLL.Service;
using BurgerOrderDAL.Abstract;
using BurgerOrderDAL.UnitOfWork;
using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Manager
{
    public class BaseManager<T> : IService<T> where T : class, IEntity
    {
        private readonly IUow _uow;
        public void Add(T entity)
        {
            _uow.GetRepository<T>().Add(entity);
            _uow.SaveChanges();
            
        }

        public void Delete(object id)
        {
            var item = _uow.GetRepository<T>().Get(id);
            if (item != null) 
            {
              _uow.GetRepository<T>().Delete(item);
                _uow.SaveChanges() ;
            
            }
        }

        public T? Get(object id)
        {
            return _uow.GetRepository<T>().Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _uow.GetRepository<T>().GetAll();
        }

        public void Update(T entity)
        {
            var item = _uow.GetRepository<T>().Get(entity);
            if (item != null) 
            {
              _uow.GetRepository<T>().Update(item);
                _uow.SaveChanges();
            
            }
        }
    }
}
