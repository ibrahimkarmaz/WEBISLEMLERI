#pragma checksum "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Shared\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25bad7ea07a24a5f9f5658746f45cff298ccfb95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
#line 1 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25bad7ea07a24a5f9f5658746f45cff298ccfb95", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreBlog.Models.UserComment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Shared\Components\CommentList\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>");
#nullable restore
#line 5 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t<p>");
#nullable restore
#line 6 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 7 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Shared\Components\CommentList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreBlog.Models.UserComment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591