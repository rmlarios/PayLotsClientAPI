#pragma checksum "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Consolidado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1f72fd8d0a0ceeecb0f21ddb055559f798bfd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Pago_Consolidado), @"mvc.1.0.razor-page", @"/Pages/Pago/Consolidado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1f72fd8d0a0ceeecb0f21ddb055559f798bfd3", @"/Pages/Pago/Consolidado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abefe4e372dfbabd28ca96f5957c69b2cb15bcf5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pago_Consolidado : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Consolidado.cshtml"
Write(Html.DevExtreme().PivotGrid<ViewPagosAsignaciones>()
    .ID("pivot").Height(800)
    .DataSource(c=>c.Store(m=>m.Mvc().Controller("Pagos").LoadAction("GetAll"))
                    .Fields(c=>
                    {
                        c.AddFor(m => m.DatoCompleto).Area(PivotGridArea.Row).Width(200);
                        //c.AddFor(m => m.MesPagadoFecha).Format("MMMM/yyyy").Area(PivotGridArea.Column);
                        c.AddFor(m => m.MesPagado).Area(PivotGridArea.Column).SortingMethod(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n function (a,b) {\r\n        alert(a + \"-\" + b);\r\n    }\r\n\r\n");
    PopWriter();
}
)).AllowSorting(true);
                        c.AddFor(m => m.TotalRecibo).Area(PivotGridArea.Data).SummaryType(SummaryType.Sum).RunningTotal(PivotGridRunningTotalMode.Row);
                        c.AddFor(m => m.NombreProyecto).Area(PivotGridArea.Filter);

                    })
                    .Paginate(true).RetrieveFields(false).Filter("[['MesPagado', '<>', null]]")
    )

    .HeaderFilter(c=>c.AllowSearch(true).Height(200).ShowRelevantValues(true))
    .FieldPanel(c=>c.Visible(true).ShowFilterFields(true).AllowFieldDragging(false))
    .AllowFiltering(true)
    .ShowTotalsPrior(PivotGridTotalsDisplayMode.Columns).ShowRowTotals(false)
    .Scrolling(c=>c.Mode(PivotGridScrollingMode.Virtual))
    .Width("100%").ShowBorders(true)
    .Texts(c=>c.GrandTotal("Total Abonado"))
    .Export(c=>c.Enabled(true))//.OnExporting("exporting")
    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>



    function exporting(e) {
        var workbook = new ExcelJS.Workbook();
        var worksheet = workbook.addWorksheet('Main sheet');
        DevExpress.excelExporter.exportPivotGrid({
            worksheet: worksheet,
            component: e.component,
            customizeCell: function (options) {
                var excelCell = options;
                excelCell.font = { name: 'Arial', size: 12 };
                excelCell.alignment = { horizontal: 'left' };
            }
        }).then(function () {
            workbook.xlsx.writeBuffer().then(function (buffer) {
                saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'PivotGrid.xlsx');
            });
        });
        e.cancel = true;
    }
</script>







");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Pago_Consolidado> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Pago_Consolidado> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Pago_Consolidado>)PageContext?.ViewData;
        public Pages_Pago_Consolidado Model => ViewData.Model;
    }
}
#pragma warning restore 1591
