﻿using CoreBlog.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreBlog.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryname = "TEKNOLOJİ", categorycount = 10 });
               list.Add(new CategoryClass { categoryname = "YAZILIM", categorycount = 14 });
              list.Add(new CategoryClass { categoryname ="SPOR",categorycount=5});

            return Json(list);
        }
    }
}
