using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryDAL : ICategoryDAL
    {
        Context c = new Context();
        public void Delete(Category p)
        {

            c.Remove(p);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Where(x=>x.CategoryID==id).FirstOrDefault();
        }

        public List<Category> GetCategories()
        {
            return c.Categories.ToList();
        }

        public List<Category> getList()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category p)
        {
            c.Categories.Add(p);
            c.SaveChanges();
        }

        public void Update(Category p)
        {
            c.Categories.Update(p);
            c.SaveChanges();
        }
    }
}
