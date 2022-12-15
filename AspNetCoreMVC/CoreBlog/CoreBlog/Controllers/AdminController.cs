using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class AdminController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
/*
 RenderBody : Master Page yapısı kurmamızı sağlar.
RenderSection ise Layout sayfasının istediğimiz bir alanında veri göstermemizi sağlar. Ayrıca " RenderSection("parametre", required: false) " bu şekilde tamamladığımızda zorunluğunu iptal edebiliriz. Bu sayede tanımladığımız parametreye ait rendersection boş bile gelse sayfada hata almayız.

Tam ayırtman özelliğini söylemek gerekirse RenderBody her sayfada kullanılıyorken RenderSection istediğimiz sayfalarda gösterebiliriz.*/