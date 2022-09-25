using CoreDepartman.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;//Claim kullanmak için
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
	public class LoginController : Controller
	{
		Context _context = new Context();
        [HttpGet]
		public IActionResult GirisYap()
		{
			return View();
		}
        public async Task<IActionResult> GirisYap(Admin admin) //Dikkat async kullanıldığında httpPost Kullanılmaz.
        {
			var bilgiler = _context.Admins.FirstOrDefault(x=>x.KullaniciAdi==admin.KullaniciAdi && x.Parola==admin.Parola);
			if (bilgiler != null)
			{
				var claims = new List<Claim> 
				{
					new Claim(ClaimTypes.Name,admin.KullaniciAdi)
				};
                var claimsIdentity=new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principala = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(principala);
                return RedirectToAction("Index", "Personel");
            }
            return View();
        }
    }
}
