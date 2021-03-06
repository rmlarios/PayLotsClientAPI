#pragma checksum "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bbfb7bd41aff46fae65f681be4f678b6b55ef8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Asignacion_Listado), @"mvc.1.0.razor-page", @"/Pages/Asignacion/Listado.cshtml")]
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
#nullable restore
#line 8 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbfb7bd41aff46fae65f681be4f678b6b55ef8b", @"/Pages/Asignacion/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abefe4e372dfbabd28ca96f5957c69b2cb15bcf5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Asignacion_Listado : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
Write(TempData["Msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n<div class=\"row text-center\" style=\"padding-bottom: 10px;\">\r\n  <div class=\"col-md-8\"></div>\r\n  <div class=\"col-md-2 font-bold\">Filtrar por Estado:</div>\r\n  <div class=\"col-md-2\">\r\n");
#nullable restore
#line 10 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
     
        var statuses = new[] { "Todos", "Anulada", "Vigente"};
    

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 13 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
Write(Html.DevExtreme().SelectBox()
        .DataSource(statuses)        
        .Value(statuses[0])               
        .OnValueChanged(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
            function(data) {
                var dataGrid = $(""#GridListado"").dxDataGrid(""instance"");
                if (data.value == ""Todos"")
                    dataGrid.clearFilter();
                else
                    dataGrid.filter([""Estado"", ""="", data.value]);
            }
        ");
    PopWriter();
}
))
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 30 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
Write(Html.DevExtreme().DataGrid<ViewAsignacionesSaldo>
                    ()
                    .ID("GridListado")
                    .DataSource(d=>d.Mvc().Controller("Asignaciones").Key("IdAsignacion")
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
                        columns.AddFor(m => m.IdAsignacion).Visible(false);
                        columns.AddFor(m => m.NombreProyecto);
                        columns.AddFor(m => m.NombreLote);
                        columns.AddFor(m => m.NombreCompleto);                     
                        columns.AddFor(m => m.MontoTotal);                     
                        columns.AddFor(m => m.Estado);                     
                        columns.AddFor(m => m.Abonado);
                        columns.AddFor(m=>m.Saldo);
                        columns.Add().Type(GridCommandColumnType.Buttons).Buttons(buttons =>{
                          buttons.Add().Name(GridColumnButtonName.Edit);
                          buttons.Add().Name("Anular").Hint("Anular").Icon("clear").OnClick("openAnular");
                        });                        
                    })
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
                        .Form(f => f.ColCount(1).ShowRequiredMark(true).LabelLocation(FormLabelLocation.Left)
                            .Items(items =>
                            {
                                items.AddSimple().IsRequired(true).DataField("IdBloque").ColSpan(1);
                                items.AddSimple().IsRequired(false).DataField("NumeroLote").ColSpan(1);
                                items.AddSimple().IsRequired(false).DataField("Area").ColSpan(1);
                                
                            }))
                          )
                       .ErrorRowEnabled(true)
                       .OnEditingStart(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                           function(e)
                           { 
                               e.cancel = true;                              
                               var id = e.data.IdAsignacion;
                               window.location.href=""/Asignacion/Registrar/?p="" + id ;
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
                               window.location.href=""/Asignacion/Registrar/?p=0"" ;
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
            WriteLiteral("\r\n\r\n \r\n<input type=\"hidden\" id=\"IdAsignacion\" name=\"IdAsignacion\">\r\n");
#nullable restore
#line 113 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
Write(Html.DevExtreme().Popup
            ()
            .ID("PopAnular")
            .Height(400)
            .Position(PositionAlignment.Center)            
            .Width(600)
            .Title("Lotes Asignados: ")
            .ShowCloseButton(true)            
            .ContentTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("                \r\n");
#nullable restore
#line 122 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
 using (Html.BeginForm("Anular","Asignaciones",FormMethod.Post))
{  
    

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
            Write(Html.DevExtreme().Form<AnularAsignacionRequest>().ID("formAnular").ColCount(2).Height(350).ShowValidationSummary(true)
                    .Items(item => {
                        item.AddSimpleFor(m=>m.Observaciones).IsRequired(true).ColSpan(2).Editor(e=>e.TextBox().StylingMode(EditorStylingMode.Outlined).Height(50));                        
                        item.AddSimpleFor(m=>m.IdAsignacion).Editor(e=>e.TextBox().Visible(false)).Visible(true);
                        item.AddGroup().ColSpan(2).ColCount(2).Items(i=>{
                            i.AddButton().Name("Anular").ColSpan(1).ButtonOptions(o=>o.Text("Aceptar").UseSubmitBehavior(true).Type(ButtonType.Danger).Width("100%"));
                            i.AddButton().Name("Cancelar").ColSpan(1).ButtonOptions(o=>o.Text("Cancelar").Type(ButtonType.Success).Width("100%"));
                        });
                    })
                    .OnInitialized("onFormInitialized").OnContentReady("onFormReady")
                );

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
                                 }

#line default
#line hidden
#nullable disable
    WriteLiteral("            ");
    PopWriter();
}
))
            
            .Visible(false).CloseOnOutsideClick(true).Position(PositionAlignment.Center)
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<script>\r\n    var IdAsignacionS,vform;\r\n\r\n     $(function(){\r\n     var msg = \"");
#nullable restore
#line 148 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
            Write(TempData["Msg"] as string);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
     if (msg !== """") {
         alert(msg);
     }
  });

    function onFormInitialized(e) {
        vform = e.component;        
        
    }

    function onFormReady(e){
        vform.getEditor(""IdAsignacion"").option(""value"",IdAsignacionS);
    }

    function openAnular(e){
        IdAsignacionS = e.row.key;
        document.getElementById(""IdAsignacion"").value = IdAsignacionS;
        var popup = $(""#PopAnular"").dxPopup(""instance"");       
        popup.option('title',e.row.data.NombreCompleto + ' ' + e.row.data.NombreLote);
        popup.show();
    }


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
        }).th");
            WriteLiteral(@"en(function () {
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
#line 201 "D:\GIT\DevExtremeAspNetCoreResponsiveApp\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Listado.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Asignacion_Listado> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Asignacion_Listado> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Asignacion_Listado>)PageContext?.ViewData;
        public Pages_Asignacion_Listado Model => ViewData.Model;
    }
}
#pragma warning restore 1591
