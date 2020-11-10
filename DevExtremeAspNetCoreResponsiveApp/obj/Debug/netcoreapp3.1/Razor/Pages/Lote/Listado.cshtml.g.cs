#pragma checksum "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Lote\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0916db8d6ac05fb835ba511af1ce014cd1b414c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Lote_Listado), @"mvc.1.0.razor-page", @"/Pages/Lote/Listado.cshtml")]
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
#line 1 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Data.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0916db8d6ac05fb835ba511af1ce014cd1b414c5", @"/Pages/Lote/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d66f5b6b80f032e48ac018b6bd23f7df879a10", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Lote_Listado : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Lote\Listado.cshtml"
Write(Html.DevExtreme().DataGrid<ViewLotes>
                    ()
                    .ID("GridListado")
                    .DataSource(d=>d.Mvc().Controller("Lotes").Key("IdLote")
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
                    .WordWrapEnabled(true)
                    .ColumnAutoWidth(true)
                    /*Columnas del grid*/
                    .Columns(columns =>
                    {
                        columns.AddFor(m => m.IdLote).Visible(false);
                        columns.AddFor(m => m.NombreProyecto);
                        columns.AddFor(m => m.NombreLote);
                        columns.AddFor(m => m.Area);                     
                        columns.AddFor(m => m.EstadoActual);                     
                        columns.AddFor(m => m.Municipio);                     
                        columns.AddFor(m => m.Departamento);
                        columns.AddFor(m=>m.NumeroLote).Visible(false);
                        columns.AddFor(m => m.IdBloque).Visible(false).Caption("Bloque").Lookup(look => look
                                                                        .DataSource(d => d.Mvc().Controller("Bloques")
                                                                                    .LoadAction("GetAll").Key("IdBloque"))   
                                                                        .DisplayExpr(new JS("lookupExpr"))
                                                                        .ValueExpr("IdBloque")
                                                                        )
                      .EditorOptions(new {  
                    searchExpr = new string[] { "NombreProyecto", "Bloque" }});                  
                    })
                    .HeaderFilter(h => h.AllowSearch(true).Visible(true))
                    /*Configuracion para la edicion*/
                    .Editing(e => e.Mode(GridEditMode.Popup)
                        .UseIcons(true)
                        .AllowAdding(true)
                        .AllowUpdating(true)
                        .AllowDeleting(true)
                        .UseIcons(true)
                        .Texts(t => t.AddRow("Nuevo").EditRow("Editar").DeleteRow("Eliminar").ConfirmDeleteMessage("¿Está seguro que desea Eliminar este Registro?")
                        .SaveRowChanges("Guardar").CancelRowChanges("Cancelar"))
                        /*Configuracion del Popup*/
                        .Popup(p => p.Width(700).Title("Formulario de Edición").ShowTitle(true).Position(PositionAlignment.Center).Height(350).CloseOnOutsideClick(false).ShowCloseButton(false))
                        /*Configuracion del EditForm*/
                        .Form(f => f.ColCount(1).ShowRequiredMark(true).LabelLocation(FormLabelLocation.Left)
                            .Items(items =>
                            {
                                items.AddSimple().IsRequired(true).DataField("IdBloque").ColSpan(1);
                                items.AddSimple().IsRequired(false).DataField("NumeroLote").ColSpan(1);
                                items.AddSimple().IsRequired(false).DataField("Area").ColSpan(1);
                                
                            }))
                          )
                       .ErrorRowEnabled(true)
);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function lookupExpr(item) {
      //alert(item);
      return item.NombreProyecto + "" "" + item.Bloque;
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

     function grid_dataSource_beforeSend(operation, ajax) {
");
            WriteLiteral("\r\n             ajax.headers = {\r\n            RequestVerificationToken: \"");
#nullable restore
#line 103 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Lote\Listado.cshtml"
                                  Write(Xsrf.GetAndStoreTokens(Model.HttpContext).RequestToken);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n        };\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Lote_Listado> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Lote_Listado> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Lote_Listado>)PageContext?.ViewData;
        public Pages_Lote_Listado Model => ViewData.Model;
    }
}
#pragma warning restore 1591
