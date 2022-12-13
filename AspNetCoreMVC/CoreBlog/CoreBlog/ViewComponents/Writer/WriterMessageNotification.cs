using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "ibrahimkarmaz@hotmail.com";
            var values = _messageManager.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
