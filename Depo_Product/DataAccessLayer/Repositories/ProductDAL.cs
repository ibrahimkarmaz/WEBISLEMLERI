using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProductDAL : IProductDAL
    {
        Context c = new Context();
        public void Delete(Product p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public Product GetById(int id)
        {
           return c.products.Where(x => x.ProductID == id).FirstOrDefault();
        }

        public List<Product> getList()
        {
            return c.products.ToList();
        }

        public List<Product> GetProducts()
        {
            return c.products.ToList();
        }

        public void Insert(Product p)
        {
          
            c.products.Add(p);
            c.SaveChanges();
        }

        public void Update(Product p)
        {
            c.products.Update(p);
            c.SaveChanges();
        }
    }
}
