#pragma checksum "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e0254f8edb4a0e13134da16cad79b9d615681c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e0254f8edb4a0e13134da16cad79b9d615681c", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogReadAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary rounded-3 d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">Blog Posts</h3>\r\n\t\t<div class=\"inner-sec\">\r\n\t\t\t<!--left-->\r\n\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-lg-4 card border-0 mb-2\">\r\n\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=", 498, "", 518, 1);
#nullable restore
#line 18 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 503, item.BlogImage, 503, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 549, "\"", 555, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 24 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
                                                                        Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t<li class=\"mx-2\">\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-comment\"></i> 0\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 34 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t<a href=\"#\">");
#nullable restore
#line 40 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
                                       Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t<p class=\"card-text mb-3\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 43 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
                                Write(item.BlogContent.Length > 150 ? item.BlogContent.Substring(0, item.BlogContent.Substring(0, 155).LastIndexOf(" ")) + "..." : item.BlogContent + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6e0254f8edb4a0e13134da16cad79b9d615681c8872", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\tDevamını Oku <i class=\"bi bi-book-fill\"></i>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
                                                                                   WriteLiteral(item.BlogID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 50 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Views\Blog\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<!--//left-->\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6e0254f8edb4a0e13134da16cad79b9d615681c11967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591