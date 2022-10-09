using Microsoft.AspNetCore.Mvc;

namespace CVProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
