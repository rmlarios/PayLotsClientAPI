#pragma checksum "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "028e93fb070290267d4b6f6eda70197c73a18dea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(AspNetCore.Pages_Index), null)]
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
#line 1 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp;

#line default
#line hidden
#line 4 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#line 6 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Index.cshtml"
using DevExtremeAspNetCoreResponsiveApp.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028e93fb070290267d4b6f6eda70197c73a18dea", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1799c17efabe6d811e9cd9e68e3cb5ba27f8b6fd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 41, true);
            WriteLiteral("\r\n<h2 class=\"content-block\">Home</h2>\r\n\r\n");
            EndContext();
            BeginContext(98, 778, false);
#line 6 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Index.cshtml"
Write(Html.DevExtreme().DataGrid<Order>()
    .ElementAttr(new { @class = "dx-card wide-card" })
    .DataSource(d => d.Mvc().Controller("Orders").LoadAction("Get").Key("OrderID"))
    .ShowBorders(false)
    .FilterRow(f => f.Visible(true))
    .FocusedRowEnabled(true)
    .FocusedRowIndex(0)
    .ColumnAutoWidth(true)
    .ColumnHidingEnabled(true)
    .Columns(columns => {
        columns.AddFor(m => m.OrderID);
        columns.AddFor(m => m.OrderDate);
        columns.AddFor(m => m.CustomerName);
        columns.AddFor(m => m.ShipCountry);
        columns.AddFor(m => m.ShipCity);
    })
    .Paging(p => p.PageSize(10))
    .Pager(p => p
        .ShowPageSizeSelector(true)
        .AllowedPageSizes(new[] { 5, 10, 20 })
        .ShowInfo(true)
    )
);

#line default
#line hidden
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
