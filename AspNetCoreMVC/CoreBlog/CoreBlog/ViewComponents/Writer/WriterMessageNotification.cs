using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager _messageManager = new Message2Manager(new EFMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = _messageManager.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
