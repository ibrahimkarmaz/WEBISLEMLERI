using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlog.ViewComponents.Writer
{
    
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EFWriterRepository());

        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var WriterID = _context.Writers.Where(x => x.WriterMail == userMail).FirstOrDefault().WriterID;
            var values = _writerManager.GetWriterByID(WriterID); 
            return View(values);
        }
    }
}
