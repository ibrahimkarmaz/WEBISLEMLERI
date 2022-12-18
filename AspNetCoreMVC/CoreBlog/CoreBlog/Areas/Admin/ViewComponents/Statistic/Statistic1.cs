using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreBlog.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EFBlogRepository());
        Context _context = new Context();
        public IViewComponentResult Invoke()
        { 
            ViewBag.v1 = _blogManager.GetList().Count;
            ViewBag.v2 = _context.Contacts.Count();
            ViewBag.v3 = _context.Comments.Count();

            string Api = "c214f7f165d4ae15bbe332cf2e058179\r\n";
            string Connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + Api;
            XDocument document = XDocument.Load(Connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
           // ViewBag.v5 = document.Descendants("").ElementAt(0).Value;


            return View();
        }
    }
}
