#pragma checksum "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Pagos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8309f9002770417c06e334093b38e7dd28b4c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Pago_Pagos), @"mvc.1.0.razor-page", @"/Pages/Pago/Pagos.cshtml")]
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
#line 9 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8309f9002770417c06e334093b38e7dd28b4c1e", @"/Pages/Pago/Pagos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ccded478ea879bcdad98436fdc08a5ed888fec9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pago_Pagos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Pagos.cshtml"
  
    ViewData["Title"] = "Pagos Registrados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Pagos.cshtml"
Write(Html.DevExtreme().DataGrid<ViewPagosAsignaciones>
                    ()
                    .ID("GridListado")
                    .DataSource(d=>d.Mvc().Controller("Pagos").Key("IdPago")
                    .LoadAction("GetTodos")
                    )
                    .DataSourceOptions(c=>c.Paginate(true).PageSize(15))
                    .RemoteOperations(c=>c.Paging(true))
                    .ShowBorders(true)
                    .ElementAttr(new { @class = "dx-card wide-card" })
                    .Export(e => e.Enabled(true).AllowExportSelectedData(true)).OnExporting("exporting")
                    //.Paging(pag => pag.PageSize(20))
                    .Pager(p => p.ShowPageSizeSelector(false).ShowNavigationButtons(true).ShowInfo(true).InfoText("Página {0} de {1} ({2} Registros)"))
                    .RowAlternationEnabled(true)
                    .HoverStateEnabled(true)
                    .Selection(s => s.Mode(SelectionMode.Single).AllowSelectAll(false))
                    .SearchPanel(s => s.Visible(true).HighlightSearchText(true).Width(400))
                    .FilterRow(f => f.ApplyFilter(GridApplyFilterMode.Auto).Visible(true).ShowAllText("Todo"))
                    .FilterSyncEnabled(true)
                    .WordWrapEnabled(true)
                    .ColumnAutoWidth(true)

                    /*Columnas del grid*/
                    .Columns(columns =>
                    {
                        columns.AddFor(m => m.NombreProyecto);
                        columns.AddFor(m => m.IdAsignacion)
                        .Caption("Asignacion").Lookup(c => c.DataSource(d => d.Mvc().Controller("Asignaciones").LoadAction("GetAll")).DisplayExpr(new JS("groupDisplay")).ValueExpr("IdAsignacion"));
                        //columns.AddFor(m => m.IdPago).Visible(false).SortOrder(SortOrder.Desc).SortIndex(0);
                        columns.AddFor(m => m.FechaRecibo).Format("dd/MM/yyyy");
                        columns.AddFor(m => m.NumeroRecibo);
                        columns.AddFor(m => m.MesPagado);
                        columns.AddFor(m => m.MontoPago);
                        columns.AddFor(m => m.Mora);
                        columns.AddFor(m => m.Interés);
                        /*columns.Add().Caption("Total").Name("Total").CalculateCellValue(

                            @<text>
                        function(rowData) {
                            var tot =  rowData.MontoPago + rowData.Interés + rowData.Mora;
                                
                        }
                        </text>


                            );*/
                        columns.AddFor(m => m.Total);
                        columns.Add().Type(GridCommandColumnType.Buttons).Fixed(true).FixedPosition(HorizontalEdge.Left).Buttons(buttons => {
                            buttons.Add().Name(GridColumnButtonName.Edit);
                        });
                    })

                    /*.Summary(c=>c.GroupItems(g=> {
                        g.AddFor(m => m.MontoPago).ShowInColumn("MontoPago").Column("MontoPago").SummaryType(SummaryType.Sum).DisplayFormat("$ #,##0.##");
                        g.AddFor(m => m.Saldo).Column("Saldo").SummaryType(SummaryType.Max).ValueFormat("currency");
                    }).TotalItems(t => {
                        t.AddFor(m => m.MontoPago).ShowInColumn("MontoPago").ValueFormat("currency").SummaryType(SummaryType.Sum);
                        t.Add().Column("Total").ShowInColumn("Total").ValueFormat("currency").SummaryType(SummaryType.Sum);
                        }
                    )
                    )*/
                    .HeaderFilter(h => h.AllowSearch(true).Visible(true))
                    /*Configuracion para la edicion*/
                    .Editing(e => e.Mode(GridEditMode.Popup)
                        .UseIcons(true)
                        .AllowAdding(true)
                        .AllowUpdating(true)
                        //.AllowDeleting(true)
                        .UseIcons(true)
                        .Texts(t => t.AddRow("Nuevo").EditRow("Editar").DeleteRow("Eliminar").ConfirmDeleteMessage("¿Está seguro que desea Eliminar este Registro?")
                        .SaveRowChanges("Guardar").CancelRowChanges("Cancelar"))
                        /*Configuracion del Popup*/
                        .Popup(p => p.Width(700).Title("Formulario de Edición").ShowTitle(true).Position(PositionAlignment.Center).Height(350).CloseOnOutsideClick(false).ShowCloseButton(false))
                          /*Configuracion del EditForm*/
                          /*.Form(f => f.ColCount(1).ShowRequiredMark(true).LabelLocation(FormLabelLocation.Left)
                              .Items(items =>
                              {
                                  items.AddSimple().IsRequired(true).DataField("IdBloque").ColSpan(1);
                                  items.AddSimple().IsRequired(false).DataField("NumeroLote").ColSpan(1);
                                  items.AddSimple().IsRequired(false).DataField("Area").ColSpan(1);

                              }))*/
                          )
                       .ErrorRowEnabled(true)
                       .OnEditingStart(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                           function(e)
                           {
                               e.cancel = true;
                               var idasignacion = e.data.IdAsignacion;
                               var idpago = e.data.IdPago;
                               window.location.href=""/Pago/Registrar/?p="" + idasignacion+"".""+idpago ;
                           }
                       ");
    PopWriter();
}
))
                       .OnInitNewRow(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                           function(e)
                           {
                               e.cancel = true;
                               var id = e.data.IdAsignacion;
                               window.location.href=""/Pago/Registrar/"";
                           }
                       ");
    PopWriter();
}
)
                       )
);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>

    function groupDisplay(rowData) {
        return 'Lote: ' + rowData.NombreLote + ' Nombre: ' + rowData.NombreCompleto;
    }

    function exporting(e) {
        var workbook = new ExcelJS.Workbook();
        var worksheet = workbook.addWorksheet('Hoja1');

        DevExpress.excelExporter.exportDataGrid({
            component: e.component,
            worksheet: worksheet,
            autoFilterEnabled: true
        }).then(function () {
            // https://github.com/exceljs/exceljs#writing-xlsx
            workbook.xlsx.writeBuffer().then(function (buffer) {
                saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'Beneficiarios.xlsx');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Pago_Pagos> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Pago_Pagos> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Pago_Pagos>)PageContext?.ViewData;
        public Pages_Pago_Pagos Model => ViewData.Model;
    }
}
#pragma warning restore 1591
