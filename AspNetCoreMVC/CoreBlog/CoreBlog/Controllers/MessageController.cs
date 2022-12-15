using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager _messageManager = new Message2Manager(new EFMessage2Repository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = _messageManager.GetInboxListByWriter(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var value = _messageManager.GetById(id);
            return View(value);
        }
    }
}
