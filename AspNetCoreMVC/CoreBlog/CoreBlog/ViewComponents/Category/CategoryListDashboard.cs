using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager  _categoryManager = new CategoryManager(new EFCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values=_categoryManager.GetList();
            return View(values);
        }
    }
}
