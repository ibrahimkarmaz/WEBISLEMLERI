using Microsoft.AspNetCore.Mvc;

namespace CVProject.ViewComponents
{
    public class FloorComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
