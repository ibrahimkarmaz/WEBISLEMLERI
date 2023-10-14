using Microsoft.AspNetCore.Mvc;

namespace Depo_Product.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
