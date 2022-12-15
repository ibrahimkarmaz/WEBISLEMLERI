using BusinessLayer.Concrete;
using BusinessLayer.ValidatonRules;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreBlog.Controllers
{
    
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
            Context _context = new Context();
            var userMail = User.Identity.Name;
            var WriterID = _context.Writers.Where(x => x.WriterMail == userMail).FirstOrDefault().WriterID;
            var values=_blogManager.GetListWithCategoryByWriter(WriterID);
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

            Context _context = new Context();
            var userMail = User.Identity.Name;
            var WriterID = _context.Writers.Where(x => x.WriterMail == userMail).FirstOrDefault().WriterID;

            ValidationResult result = _blogValidator.Validate(blog.Blogs);
            if (result.IsValid)
            {
                blog.Blogs.BlogStatus = true;
                blog.Blogs.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.Blogs.WriterID = WriterID;
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
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = _blogManager.GetById(id);
            _blogManager.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = _blogManager.GetById(id);
            var BlogModel=new BlogModel();
            BlogModel.Blogs = blogvalue;
            return View(BlogModel);
        }

        [HttpPost]
        public IActionResult EditBlog(BlogModel p)
        {
            var blogvalue = _blogManager.GetById(p.Blogs.BlogID);
           
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(p.Blogs);
            if (result.IsValid)
            {
                blogvalue.BlogTitle = p.Blogs.BlogTitle;
                blogvalue.BlogImage = p.Blogs.BlogImage;
                blogvalue.BlogThumbnailImage = p.Blogs.BlogThumbnailImage;
                blogvalue.BlogTitle = p.Blogs.BlogTitle;
                blogvalue.CategoryID = p.Blogs.CategoryID;
                blogvalue.BlogContent = p.Blogs.BlogContent;

                _blogManager.TUpdate(blogvalue);
                return RedirectToAction("BlogListByWriter");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);
        }
    }
}
//https://stackoverflow.com/questions/1390830/mvc-set-selected-value-of-selectlist