using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	public class AboutController : Controller
	{//42.VİDEODAN DEVAM ET.
		AboutManager _aboutManager = new AboutManager(new EFAboutRepository());
		public IActionResult Index()
		{
			var values = _aboutManager.GetList();
			return View(values);
		}
		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}
