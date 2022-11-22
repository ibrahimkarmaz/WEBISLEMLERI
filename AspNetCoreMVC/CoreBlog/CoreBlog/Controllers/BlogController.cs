using BusinessLayer.Concrete;
using BusinessLayer.ValidatonRules;
using CoreBlog.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = _blogManager.GetBlogListWithCategory();

            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var values = _blogManager.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values=_blogManager.GetBlogListByWriter(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            var CategoryAndBlogModel = new BlogModel();
            /*DİREK HOCANIN ÇEKTİĞİ GİBİ ÇEKSEKTE SONUNDA EKLEMEK İÇİN BU ŞEKİLDE KULLANILARA BİLİR SEÇİM İŞLEMİ SELECTED
             3 SAYISI BENDE TEKNOLOJİYE DENK GELİYOR :) BUNU VERİ ALIRKEN KULLANILABİLİR DEĞİŞKEN OLARAK*/
            CategoryAndBlogModel.CategoryValues.FirstOrDefault(x => x.Value.ToString() == (3).ToString()).Selected = true;//DİSABLED İÇİN KULLANILABİLİR.
            return View(CategoryAndBlogModel);
        }
        [HttpPost]
        public IActionResult BlogAdd(BlogModel blog)
        {
            BlogValidator _blogValidator = new BlogValidator();
            
            ValidationResult result = _blogValidator.Validate(blog.Blogs);
            if (result.IsValid)
            {
                blog.Blogs.BlogStatus = true;
                blog.Blogs.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.Blogs.WriterID = 1;
                _blogManager.TAdd(blog.Blogs);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();//EĞER HATA VAR İSE YİNE AYNI PENCERE AÇILIR FAKAT WRİTER ALINAN BİLGİYİ GERİ DÖNDÜRÜR.
        }
    }
}
//https://stackoverflow.com/questions/1390830/mvc-set-selected-value-of-selectlist