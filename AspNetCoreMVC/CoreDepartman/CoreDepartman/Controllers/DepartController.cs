using Microsoft.AspNetCore.Mvc;
using CoreDepartman.Models;
using System.Linq;

namespace CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var degerler = _context.Departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(Departmanlar Departman)
        {
            _context.Departmanlars.Add(Departman);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var sorgu = _context.Departmanlars.Find(id);
            _context.Departmanlars.Remove(sorgu);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var departman = _context.Departmanlars.Find(id);
            return View(departman);
        }

        public IActionResult DepartmanGuncelle(Departmanlar departmanlar)
        {
            var departmanx = _context.Departmanlars.Find(departmanlar.ID);
            departmanx.DepartmanAd = departmanlar.DepartmanAd;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanDetay(int id)
        {
            var degerler=_context.Personels.Where(x=>x.DepartmanID==id).ToList();
            ViewBag.baslik= _context.Departmanlars.Where(y => y.ID == id).FirstOrDefault().DepartmanAd;

            return View(degerler);
        }
    }
}
