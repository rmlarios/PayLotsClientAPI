#pragma checksum "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\PagosFechas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d6f3c75952e4e696f7a2a355c5c36c472eb13f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Reportes_PagosFechas), @"mvc.1.0.razor-page", @"/Pages/Reportes/PagosFechas.cshtml")]
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
#line 1 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d6f3c75952e4e696f7a2a355c5c36c472eb13f", @"/Pages/Reportes/PagosFechas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abefe4e372dfbabd28ca96f5957c69b2cb15bcf5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reportes_PagosFechas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\PagosFechas.cshtml"
  
    ViewData["Title"] = "Pagos por Fechas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-4\"></div>\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 10 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\PagosFechas.cshtml"
    Write(Html.DevExtreme().PieChart().ID("mychart")
        .DataSource(d=>d.Mvc().Controller("Pagos").LoadAction("GetGrafico").OnBeforeSend("onBeforeSend")
        //.LoadParams(new { Fecha = new JS("getFecha") })
        )

        .Animation(true)
        .Export(c=>c.Enabled(true))
        .Palette(VizPalette.Material)
        .Legend(l=>l.HoverMode(PieChartLegendHoverMode.AllArgumentPoints).Title("Proyectos"))
        .Theme(VizTheme.MaterialTealLight)
        .Tooltip(t=>t.Enabled(true).Shared(true))
        .Series(s=>s.Add().ArgumentField("NombreProyecto").ValueField("Pagado").Label(l=>l.Visible(true).Position(PieChartLabelPosition.Inside).Format(Format.Decimal)))
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"col-md-4\"></div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\"></div>\r\n    <div class=\"col-md-6 font-weight-bold\">\r\n        ");
#nullable restore
#line 31 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\PagosFechas.cshtml"
    Write(Html.DevExtreme().Calendar().ID("mycalendar")
        .ShowTodayButton(true)
        .Max(DateTime.Today)
        .FirstDayOfWeek(FirstDayOfWeek.Monday)
        .Width("100%").Height(400)
        .OnValueChanged("ondateChanged")
        .Value(DateTime.Today.Date)
        .OnInitialized("calendarInit")
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-3\"></div>\r\n</div>\r\n\r\n");
#nullable restore
#line 44 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\PagosFechas.cshtml"
Write(Html.DevExtreme().Button()
    .Text("Refresh Grid")
    .OnClick("reloadData")
);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script>
    var cdate, calendar, IsfirstLoad = true;

    function onBeforeSend(s, e) {
        if(cdate!=null)
            e.data.Fecha = cdate;//$(""#dateBox"").dxDateBox(""instance"").option(""value"");
        else
            e.data.Fecha = new Date().toLocaleDateString();
    }

    function reloadData() {
        $(""#mychart"").dxChart().dxChart(""getDataSource"").reload();
    }

    function calendarInit(e) {
        calendar = e.component;
        //calendar = $(""#calendar-container"").dxCalendar(""instance"");
        cdate = calendar.option(""value"");
    }

    function getFecha() {
    //    var cal = $(""#mycalendar"").dxCalendar().dxCalendar(""instance"")
      //  if (cal.option(""value"") != null)
        if(cdate!=null)
            return cdate;
        else
            return new Date().toLocaleDateString();
    }



    function ondateChanged(data) {
        //alert(data.value);
        cdate = new Date(data.value).toLocaleDateString();
        alert(cdate);
     ");
            WriteLiteral(@"   //$(""#mychart"").dxChart().dxChart(""instance"").getDataSource().reload()
        //var ds = $(""#mychart"").dxChart().dxChart(""getDataSource"")
       //var ds = $(""#mychart"").dxChart().dxChart(""getDataSource"");
        //ds.load();
        //var chart = $(""#mychart"").dxChart().dxChart({ dataSource: ds });
        //var ds = chart.option('dataSource');
//        chart.option('dataSource', ds);
        //var chart = $(""#mychart"").data(""dxChart"");
        //chart.render();



    }

      function chart_beforeSend(operation, ajax) {
");
            WriteLiteral("\r\n             ajax.headers = {\r\n            RequestVerificationToken: \"");
#nullable restore
#line 107 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\PagosFechas.cshtml"
                                  Write(Xsrf.GetAndStoreTokens(Model.HttpContext).RequestToken);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n        };\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.PagosFechasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.PagosFechasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.PagosFechasModel>)PageContext?.ViewData;
        public DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.PagosFechasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
