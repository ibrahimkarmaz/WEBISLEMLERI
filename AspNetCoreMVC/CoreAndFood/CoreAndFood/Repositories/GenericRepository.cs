using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        Context _context = new Context();

        public List<T> TList()
        {
            return _context.Set<T>().ToList();
        }

        public void TAdd(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }
        public void TDelete(T t)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }

        public void TUpdate(T t)
        {
            _context.Set<T>().Update(t);
            _context.SaveChanges();
        }

        public T TGet(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> TList(string p)
        {
            return _context.Set<T>().Include(p).ToList();
        }

        public List<T> List(Expression<Func<T,bool>> filter=null)
        {
            return _context.Set<T>().Where(filter).ToList();
        }
    }
}
