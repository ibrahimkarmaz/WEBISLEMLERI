using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	public class CommentController : Controller
	{
		CommentManager _blogManager=new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
        public PartialViewResult CommentListByBlog(int id)
        {
			var values =_blogManager.GetList(id);
            return PartialView(values);
        }
    }
}
