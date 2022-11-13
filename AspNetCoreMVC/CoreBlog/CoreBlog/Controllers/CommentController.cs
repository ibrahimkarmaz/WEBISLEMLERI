using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreBlog.Controllers
{
	public class CommentController : Controller
	{
		CommentManager _commentManager=new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			ViewData["data"] = new Comment();
			return PartialView();
		}
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 22;
			_commentManager.CommentAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
			var values = _commentManager.GetList(id);
            return PartialView(values);
        }
    }
}
