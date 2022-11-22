using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;

namespace CoreBlog.Models
{
    public class BlogModel
    {
        CategoryManager _categoryManager = new CategoryManager(new EFCategoryRepository());
        public List<SelectListItem> CategoryValues { get; set; }
        public Blog Blogs { get; set; }
        public BlogModel()
        {
            CategoryValues  = (from category in _categoryManager.GetList()
                                                                 select new SelectListItem
                                                                 {
                                                                     Text = category.CategoryName,
                                                                     Value = category.CategoryID.ToString()
                                                                 }).ToList();
        }
      
    }
}
