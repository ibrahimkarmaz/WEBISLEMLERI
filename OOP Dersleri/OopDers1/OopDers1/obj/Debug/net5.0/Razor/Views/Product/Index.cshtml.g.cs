#pragma checksum "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77578d962a21f698dfcfbf2d5c2bf8207a4deaff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\_ViewImports.cshtml"
using OopDers1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\_ViewImports.cshtml"
using OopDers1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
using OopDers1.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77578d962a21f698dfcfbf2d5c2bf8207a4deaff", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ead3b003eebb7d69fafd70e5d685e9151bc0176", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CoreLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ürün Sayfası</h1>

<table class=""table table-bordered table-dark table-hover"">
    
    <tr>
        <th>#</th>
        <th>ÜRÜN ADI</th>
        <th>FİYAT</th>
        <th>STOK</th>
        <th>SİL</th>
        <th>DÜZENLE</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 23 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 597, "\"", 635, 2);
            WriteAttributeValue("", 604, "/Product/DeleteProduct/", 604, 23, true);
#nullable restore
#line 27 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
WriteAttributeValue("", 627, item.ID, 627, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">SİL</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 738, 2);
            WriteAttributeValue("", 707, "/Product/UpdatePruduct/", 707, 23, true);
#nullable restore
#line 28 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
WriteAttributeValue("", 730, item.ID, 730, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">DÜZENLE</a></td>\r\n        </tr>\n");
#nullable restore
#line 30 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\OOP Dersleri\OopDers1\OopDers1\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Product/AddProduct/\" class=\"btn btn-primary\">YENİ ÜRÜN GİRİŞİ</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
