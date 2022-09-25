using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T t)
        {
            using var _context = new Context();
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var _context = new Context();
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var _context = new Context();
            return _context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var _context = new Context();
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            using var _context = new Context();
            _context.Update(t);
        }
    }
}
