#pragma checksum "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Areas\Admin\Views\Chart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9898c892e3d3975f515c4933f0fd4f922f0c23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chart_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9898c892e3d3975f515c4933f0fd4f922f0c23", @"/Areas/Admin/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ibrah\OneDrive\Belgeler\WEBDERSLERI\WEBISLEMLERI\AspNetCoreMVC\CoreBlog\CoreBlog\Areas\Admin\Views\Chart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://www.google.com/jsapi""></script>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        $.ajax({
            type: ""POST"",
            dataType: ""json"",
            contentType: ""application/json"",
            url: '/Admin/Chart/CategoryChart',
            success: function (result) {
                google.charts.load('current', {
                    'packages': ['corechart']
                });
                google.charts.setOnLoadCallback(function () {
                    drawChart(result);
                });
            }
        });
    });
    function drawChart(result) {
        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Ad');
        data.addColumn('number', 'Yüzdeler');
        var dataArray = [];
        $.each(resul");
            WriteLiteral(@"t, function (i, obj) {
            dataArray.push([obj.categoryname, obj.categorycount]);
        });
        data.addRows(dataArray);
        var columnChartOptions = {
            title: ""Blog Pie - Puan"",
            width: 800,
            height: 600,
            bar: { groupWidth: ""20%"" },
        };
        var columnChart = new google.visualization.PieChart(document
            .getElementById('chartdiv'));
        columnChart.draw(data, columnChartOptions);
    }
</script>



<div class=""row"">
    <div class=""col-lg-12"">
        <div id=""chartdiv"" style=""width:800px;height:600px"">
            <h2>BURASI CHART ALANIDIR.</h2>
        </div>
    </div>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
