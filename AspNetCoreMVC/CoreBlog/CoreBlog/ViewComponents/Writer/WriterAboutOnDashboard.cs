using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Writer
{
    
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = _writerManager.GetWriterByID(1);
            return View(values);
        }
    }
}
