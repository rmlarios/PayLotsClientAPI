#pragma checksum "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7cadf08eff9c161630106df390d4ddbb39e2a06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Pago_Listado), @"mvc.1.0.razor-page", @"/Pages/Pago/Listado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cadf08eff9c161630106df390d4ddbb39e2a06", @"/Pages/Pago/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ccded478ea879bcdad98436fdc08a5ed888fec9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pago_Listado : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Listado.cshtml"
  
    ViewData["Title"] = "Pagos Registrados por Asignación";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Listado.cshtml"
Write(Html.DevExtreme().DataGrid<ViewPagosAsignaciones>
                    ()
                    .ID("GridListado")
                    .DataSource(d=>d.Mvc().Controller("Pagos").Key("IdPago")
                    .LoadAction("GetAll")
                    .InsertAction("PostCreate")
                    .UpdateAction("PutUpdate")
                    .DeleteAction("DeletebyId")
                    .OnBeforeSend("grid_dataSource_beforeSend")
                    )
                    .ShowBorders(false)
                    .ElementAttr(new { @class = "dx-card wide-card" })
                    .Export(e => e.Enabled(true).AllowExportSelectedData(true)).OnExporting("exporting")
                    .Paging(pag => pag.PageSize(10))
                    .Pager(p => p.ShowPageSizeSelector(false).ShowNavigationButtons(true).ShowInfo(true).InfoText("Página {0} de {1} ({2} Registros)"))
                    .RowAlternationEnabled(true)
                    .HoverStateEnabled(true)
                    .Selection(s => s.Mode(SelectionMode.Single).AllowSelectAll(false))
                    .SearchPanel(s => s.Visible(true).HighlightSearchText(true).Width(400))
                    .FilterRow(f => f.ApplyFilter(GridApplyFilterMode.Auto).Visible(true).ShowAllText("Todo"))
                    .FilterSyncEnabled(true)
                    .Grouping(c=>c.AutoExpandAll(false))
                    .WordWrapEnabled(true)
                    .ColumnAutoWidth(true)

                    /*Columnas del grid*/
                    .Columns(columns =>
                    {
                    columns.AddFor(m=>m.IdAsignacion).Visible(false).Caption("Lote").AllowSearch(true).CalculateDisplayValue(new JS("groupDisplay")).CalculateCellValue(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n  function (rowData) {\r\n       // alert(rowData.IdAsignacion);\r\n        return rowData.IdAsignacion;\r\n    }\r\n");
    PopWriter();
}
))
                    .GroupCellTemplate(new JS("groupTemplate")).CalculateGroupValue(new JS("groupValue"));

                        columns.AddFor(m => m.IdAsignacion).GroupIndex(0)
        .GroupCellTemplate(new JS("groupTemplate"))
        .Caption("Asignacion").Lookup(c => c.DataSource(d => d.Mvc().Controller("Asignaciones").LoadAction("GetAll")).DisplayExpr(new JS("groupDisplay")).ValueExpr("IdAsignacion"));
                        columns.AddFor(m => m.IdPago).Visible(false);
                        columns.AddFor(m => m.NumeroAbono);
                        columns.AddFor(m => m.NumeroRecibo);
                        columns.AddFor(m => m.MesPagado);
                        columns.AddFor(m => m.MontoPago);
                        columns.AddFor(m => m.Mora);
                        columns.AddFor(m => m.Interés);
                        columns.AddFor(m => m.Abonado).Visible(false);
                        columns.AddFor(m => m.Saldo).Visible(false).Format("$ #,##0.##");

                        columns.Add().Type(GridCommandColumnType.Buttons).Fixed(true).FixedPosition(HorizontalEdge.Left).Buttons(buttons => {
                            buttons.Add().Name(GridColumnButtonName.Edit);
                        });
                    })

                    .Summary(c=>c.GroupItems(g=> {
                        g.AddFor(m => m.MontoPago).ShowInColumn("MontoPago").Column("MontoPago").SummaryType(SummaryType.Sum).DisplayFormat("$ #,##0.##");
                        g.AddFor(m => m.Saldo).Column("Saldo").SummaryType(SummaryType.Max).ValueFormat("currency");
                    }).TotalItems(t=>t.AddFor(m=>m.MontoPago).ShowInColumn("MontoPago").ValueFormat("currency").SummaryType(SummaryType.Sum)))
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


    function groupTemplate(cellElement, cellInfo) {
        var groupKey = cellInfo.displayValue + ' Abonado: ' + cellInfo.summaryItems[0].value + ' Saldo: ' + cellInfo.summaryItems[1].value;
        $('<span>')
            .text(groupKey)
            .appendTo(cellElement);
        $(""<div>"")
            .css({ 'float': 'left'})
            .dxButton({
                text: """",
                icon: ""fa fa-plus"",
                stylingMode: ""contained"",
                hint:""Registrar pago"",
                type: ""success"",
                onClick: function (e) {
                    var idpago= cellInfo.data.key;
                    window.location.href = ""/Pago/Registrar/?p="" + idpago;
                }
            }).appendTo(cellElement);
    }

    function groupDisplay(rowData) {
        return 'Lote: ' + rowData.NombreLote + ' Nombre: ' + rowData.NombreCompleto ;
    }

    function groupValue(rowData) {
        return rowData.IdAsignacion;
    }

    func");
            WriteLiteral("tion grid_dataSource_beforeSend(operation, ajax) {\r\n");
            WriteLiteral("\r\n             ajax.headers = {\r\n            RequestVerificationToken: \"");
#nullable restore
#line 145 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Pago\Listado.cshtml"
                                  Write(Xsrf.GetAndStoreTokens(Model.HttpContext).RequestToken);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
        };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Pago_Listado> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Pago_Listado> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Pago_Listado>)PageContext?.ViewData;
        public Pages_Pago_Listado Model => ViewData.Model;
    }
}
#pragma warning restore 1591
