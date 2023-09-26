using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    internal class ProductManager : IProductService
    {
        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public Product GetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public void TAdd(Product t)
        {
            _productDAL.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDAL.Delete(t);
        }

        public List<Product> TGetList()
        {
            return _productDAL.getList();
        }

        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }
    }
}
