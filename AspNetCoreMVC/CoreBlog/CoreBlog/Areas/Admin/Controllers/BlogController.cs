using ClosedXML.Excel;
using CoreBlog.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreBlog.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            //Excel Arkaplanda oluşturma XLWorkbook() ile
            using (var workbook = new XLWorkbook())
            {
                //ÇALIŞMA SAYFASINI OLUŞTURMA VE BAŞLIKLARI BELİRME
                var worksheet = workbook.Worksheets.Add("Blog Listesi");//ÇALIŞMA SAYFA ADI
                worksheet.Cell(1, 1).Value = "BLOG ID";//BAŞLIKLAR A1
                worksheet.Cell(1, 2).Value = "BLOG ADI";//BAŞLIKLAR A2

                int blogRowCount = 2;//1.SATIR BAŞLIKLARA AYRILDIĞI İÇİN 2.SATIRDAN BAŞLANDI

                //İÇERİKLERİ EKLEME
                foreach (var item in new List<BlogModelX>
                {
                new BlogModelX{ID=1,BlogName="C# GİRİŞ"},
                new BlogModelX{ID=2,BlogName="TESLA FİRMASI ARAÇLARI"},
                new BlogModelX{ID=3,BlogName="2023 OLİMPİYATLARİ"}
                })
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.ID;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;//2.SATIRDAN 3....DİYE DEVAM ETME
                }
                //MemoryStream (Bellek Akışı)dan referans alma
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);//EXCELİ KAYDETME
                    var content = stream.ToArray();//TO ARRAY LİSTE ÇEVİRME
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                    //RETURN KISMIDA İSE SIRASIYLA File(İçerik bilgileri,Excel oluşturma bilgileri,Excel Adi ve Uzantısı)
                }
            }
            // return View();
        }

        public IActionResult BlogListExcel()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                //ÇALIŞMA SAYFASINI OLUŞTURMA VE BAŞLIKLARI BELİRME
                var worksheet = workbook.Worksheets.Add("Blog Listesi");//ÇALIŞMA SAYFA ADI
                worksheet.Cell(1, 1).Value = "BLOG ID";//BAŞLIKLAR A1
                worksheet.Cell(1, 2).Value = "BLOG ADI";//BAŞLIKLAR A2

                int blogRowCount = 2;//1.SATIR BAŞLIKLARA AYRILDIĞI İÇİN 2.SATIRDAN BAŞLANDI

                //İÇERİKLERİ EKLEME

                List<BlogModel2> bm = new List<BlogModel2>();
                using (var c=new Context())
                {
                    bm = c.Blogs.Select(x => new BlogModel2
                    {
                        Id = x.BlogID,
                        BlogName = x.BlogTitle
                    }).ToList();
                }



                    foreach (var item in bm)
                    {
                        worksheet.Cell(blogRowCount, 1).Value = item.Id;
                        worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                        blogRowCount++;//2.SATIRDAN 3....DİYE DEVAM ETME
                    }
                //MemoryStream (Bellek Akışı)dan referans alma
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);//EXCELİ KAYDETME
                    var content = stream.ToArray();//TO ARRAY LİSTE ÇEVİRME
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                    //RETURN KISMIDA İSE SIRASIYLA File(İçerik bilgileri,Excel oluşturma bilgileri,Excel Adi ve Uzantısı)
                }
            }
        }

        public IActionResult BlogTitleListExcel()
        {
            return View();
        }
    }
}
