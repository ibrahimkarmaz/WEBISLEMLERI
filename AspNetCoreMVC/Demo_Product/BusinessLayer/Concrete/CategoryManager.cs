using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _CategoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _CategoryDAL = categoryDAL;
        }

        public void TDelete(Category t)
        {
            _CategoryDAL.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _CategoryDAL.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _CategoryDAL.GetAll();
        }

        public void TInsert(Category t)
        {
            _CategoryDAL.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _CategoryDAL.Update(t);
        }
    }
}
