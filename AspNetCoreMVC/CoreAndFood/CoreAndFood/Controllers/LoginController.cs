using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class LoginController : Controller
    {
        Context _context = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            var datavalue = _context.Admins.FirstOrDefault(x=>x.UserName==admin.UserName && x.Password==admin.Password);
            if (datavalue!=null)
            {
                var claim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.UserName)
                };

                var userIdentity = new ClaimsIdentity(claim,"Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Category");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Login");
        }
    }
}
