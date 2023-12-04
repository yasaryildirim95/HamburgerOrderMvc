using BurgerOrderDAL.Abstract;
using BurgerOrderDAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderDAL.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AppDbContext _context;

        public Uow(AppDbContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        IRepo<T> IUow.GetRepository<T>()
        {
            return new GenericRepo<T>(_context);
        }
    }
}
