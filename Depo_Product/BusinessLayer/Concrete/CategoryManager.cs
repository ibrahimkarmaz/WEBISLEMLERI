﻿using BusinessLayer.Abstract;
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

        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public Category GetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public void TAdd(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public List<Category> TGetList()
        {
            return _categoryDAL.getList();
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
