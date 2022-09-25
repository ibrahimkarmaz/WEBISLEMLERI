using CoreDepartman.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreDepartman.Controllers
{
    public class PersonelController : Controller
    {
        Context _context = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = _context.Personels.Include(x=>x.Departman).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            DepartmanPersonelView Sorgu = new DepartmanPersonelView()
            {
                Personel = new Personel(),
                DepartmanList = new List<SelectListItem>((from a in _context.Departmanlars.ToList()
                                                          select new SelectListItem
                                                          {
                                                              Text = a.DepartmanAd,
                                                              Value = a.ID.ToString()
                                                          }).ToList())
            };

          /*  List<SelectListItem> degerler = (from a in _context.Departmanlars.ToList()
                                             select new SelectListItem
                                             {
                                                 Text=a.DepartmanAd,
                                                 Value=a.ID.ToString()
                                             }).ToList();
            ViewBag.degerler = degerler;*/
            return View(Sorgu);
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel personel)
        {
            var sorgu = _context.Departmanlars.Find(personel.Departman.ID);
            personel.DepartmanID = (int)sorgu.ID;
            personel.Departman = null;

            _context.Personels.Add(personel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
