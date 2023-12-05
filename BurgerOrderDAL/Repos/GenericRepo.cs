using BurgerOrderDAL.Abstract;
using BurgerOrderDAL.Context;
using BurgerOrderEntity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderDAL.Repos
{
    public class GenericRepo<T> : IRepo<T> where T : class, IEntity
    {
        protected AppDbContext _context;
        protected DbSet<T> _dbSet;

        public GenericRepo(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T? Get(object id)
        {
            return _dbSet.Find(id);
        }

        public T? Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).FirstOrDefault();
        }

        public List<T> GetAll(bool noTracking = true)
        {
            return noTracking ?
                     _dbSet.AsNoTracking().ToList() :
                     _dbSet.ToList();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbSet.AsQueryable<T>();
        }

    }
}
