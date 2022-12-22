using CoreBlog.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CoreBlog.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class WriterController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetWriterByID(int writerid)
        {
            var findwriter = writers.Find(x=>x.Id==writerid);
            var findWriters = JsonConvert.SerializeObject(findwriter);
            return Json(findWriters);
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id= 1,
                Name="Ayşe"
            },
             new WriterClass
            {
                Id= 2,
                Name="Ahmet"
            },
              new WriterClass
            {
                Id= 3,
                Name="Buse"
            }
        };

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }

		[HttpPost]
		public IActionResult DeleteWriter(int id)
		{
            var writer = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);
		}

		[HttpPost]
		public IActionResult UpdateWriter(WriterClass w)
		{
            var writer = writers.FirstOrDefault(x => x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
		}
	}
}
 