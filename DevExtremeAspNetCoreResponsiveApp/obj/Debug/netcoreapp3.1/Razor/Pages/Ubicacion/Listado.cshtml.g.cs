#pragma checksum "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522349049d8d67a18f67e8ceec66b062f32ee087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Ubicacion_Listado), @"mvc.1.0.razor-page", @"/Pages/Ubicacion/Listado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522349049d8d67a18f67e8ceec66b062f32ee087", @"/Pages/Ubicacion/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ccded478ea879bcdad98436fdc08a5ed888fec9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ubicacion_Listado : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
  
    ViewData["Title"] = "Proyectos Registrados";   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
 using (Html.BeginForm()){

   


#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
Write(Html.DevExtreme().DataGrid<ViewConsolidadoUbicaciones>
                    ()
                    .ID("GridListado")
                    .DataSource(d=>d.Mvc().Controller("Ubicaciones").Key("IdUbicacion").LoadAction("GetAll")
                    .InsertAction("PostCreate").UpdateAction("PutUpdate").DeleteAction("DeletebyId"))                                                            
                    .ShowBorders(false)
                    .ElementAttr(new { @class = "dx-card wide-card" })
                    .ColumnHidingEnabled(true)
                    .FilterPanel(f => f.Visible(true))
                    .FilterBuilder(c => c.Visible(true))                    
                    .Export(e => e.Enabled(true).AllowExportSelectedData(true)).OnExporting("exporting")
                    .Paging(pag => pag.PageSize(10))
                    .Pager(p => p.ShowPageSizeSelector(false).ShowNavigationButtons(true).ShowInfo(true).InfoText("Página {0} de {1} ({2} Registros)"))
                    .RowAlternationEnabled(true)
                    .HoverStateEnabled(true)                    
                    .Selection(s => s.Mode(SelectionMode.Single).AllowSelectAll(false))
                    .SearchPanel(s => s.Visible(true).HighlightSearchText(true).Width(400).Placeholder("Buscar..."))
                    .FilterRow(f => f.ApplyFilter(GridApplyFilterMode.Auto).Visible(true).ShowAllText("Todos"))
                    
                    .WordWrapEnabled(true)
                    .ColumnAutoWidth(true)
                    /*Columnas del grid*/
                    .Columns(columns =>
                    {
                        columns.AddFor(m => m.IdUbicacion).Visible(false);
                        columns.AddFor(m => m.NombreProyecto);
                        columns.AddFor(m => m.Direccion);
                        columns.AddFor(m => m.Bloques);
                        columns.AddFor(m => m.Asignados);
                        columns.AddFor(m => m.Diponibles);
                        columns.AddFor(m => m.IdMunicipio).Caption("Municipio").Lookup(look => look
                                                                        .DataSource(d => d.Mvc().Controller("Catalogo")
                                                                                    .LoadAction("GetAll").Key("MunicipioId").InsertAction("PostCreate").UpdateAction("PutUpdate")
                                                                                    .DeleteAction("DeletebyId"))
                                                                         
                                                                        .DisplayExpr("Municipio")
                                                                        .ValueExpr("MunicipioId")
                                                                        );
                        columns.AddFor(m=>m.AplicaInteres).Caption("Intereses");
                        
                        columns.Add().Type(GridCommandColumnType.Buttons).Width(200).Buttons(b =>
                        {
                            b.Add().Name(GridColumnButtonName.Edit);
                            b.Add().Name(GridColumnButtonName.Delete);                            
                            b.Add().Icon("chevrondown").Visible(true).Hint("Detalle").OnClick("openDetail");
                        });
                    }).HeaderFilter(h => h.AllowSearch(true).Visible(true))
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
                        .Form(f => f.ColCount(2).ShowRequiredMark(true).LabelLocation(FormLabelLocation.Left)
                            .Items(items =>
                            {
                                items.AddSimpleFor(m => m.NombreProyecto).IsRequired(true).ColSpan(2);
                                items.AddSimpleFor(m=> m.Direccion).IsRequired(true).ColSpan(2);
                                items.AddSimpleFor(m=>m.IdMunicipio).IsRequired(true);
                                items.AddSimpleFor(m=> m.AplicaInteres);
                                
                            }))
                          )
                       .ErrorRowEnabled(true)
                       /*Eventos*/
                       .OnRowDblClick(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                           function(e)
                           {
                               var dataGrid = $(""#GridListado"").dxDataGrid(""instance"");
                               dataGrid.editRow(e.rowIndex);                               
                           }
                       ");
    PopWriter();
}
))
                       .OnCellClick(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                           function(e)\r\n                           {                                \r\n                                DevExpress.ui.notify(e.row.data.NombreProyecto, \"success\", 600);\r\n                           }\r\n                       ");
    PopWriter();
}
))
                       .OnInitialized("isAdministrador")
);

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
Write(Html.DevExtreme().Popup
            ()
            .ID("PopBloques")
            .Height(650)
            .Position(PositionAlignment.Center)            
            .Width(750)          
            .ShowCloseButton(true)
            .ContentTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("                              \r\n                ");
#nullable restore
#line 109 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
            Write(Html.DevExtreme().DataGrid<ViewConsolidadoBloques>().ID("gridBloques")
                                            .AllowColumnResizing(true)
                                            .FilterRow(f => f.Visible(true))
                                            .RowAlternationEnabled(true)
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
                                                        .Form(f => f.ColCount(2).ShowRequiredMark(true).LabelLocation(FormLabelLocation.Left)
                                                        .Items(items =>
                                                        {
                                                            items.AddSimpleFor(m=> m.Bloque).IsRequired(true).ColSpan(2);
                                                            items.AddSimpleFor(m=>m.Observaciones).ColSpan(2);

                                                        })))
                                            .DataSource(d=> d.Mvc()
                                            .Controller("Bloques")
                                            .LoadAction("GetbyId")
                                            .LoadParams(new { id = new JS("getUbicacionId") })
                                            .InsertAction("PostCreate")
                                            .DeleteAction("DeletebyId")
                                            .UpdateAction("PutUpdate")
                                            .Key("IdBloque"))

                                            .Columns(c =>
                                            {
                                                c.AddFor(m=>m.IdBloque).Visible(false);
                                                c.AddFor(m=>m.IdUbicacion).Visible(false);
                                                c.AddFor(m=>m.Bloque);
                                                c.AddFor(m => m.Observaciones);
                                                c.AddFor(m=>m.Asignados);
                                                c.AddFor(m=>m.Disponibles);
                                                c.Add().Caption("Lotes").CalculateCellValue("calcTotal");
                                                c.AddFor(m=>m.Observaciones).Visible(false);
                                            })

                                            .NoDataText("No hay Datos que mostrar")
                                            .Paging(pag => pag.PageSize(6))
                                            .Pager(p => p.ShowPageSizeSelector(false).ShowNavigationButtons(true).ShowInfo(true).InfoText("Página {0} de {1} ({2} Registros)"))
                                            .OnRowInserting("onRowInsertingDetail")
                                            .OnRowInserted("onrowInsertedDetail")
                                            .OnInitialized("isAdministradorBloques")


                );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n            ");
    PopWriter();
}
))
            .Visible(false).CloseOnOutsideClick(false).Position(PositionAlignment.Center)
);

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
 


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script>\r\n    var IdUbicacion\r\n    function openDetail(e) {\r\n        IdUbicacion = e.row.key;\r\n        var popup = $(\"#PopBloques\").dxPopup(\"instance\");\r\n        popup.option(\'title\',e.row.data.NombreProyecto);\r\n        popup.show();\r\n");
            WriteLiteral(@"        $(""#gridBloques"").dxDataGrid(""refresh"");
    }

    function getUbicacionId() {
        return IdUbicacion;
    }

    function calcTotal(data)
    {
        return data.Asignados + data.Disponibles;
    }

    function onRowInsertingDetail(e)
    {
        e.data.IdUbicacion = IdUbicacion;
    }

    function onrowInsertedDetail(e)
    {
        DevExpress.ui.notify(""Creado Correctamente"",""success"",900);
    }

     function exporting(e) {
        var workbook = new ExcelJS.Workbook();
        var worksheet = workbook.addWorksheet('Employees');

        DevExpress.excelExporter.exportDataGrid({
            component: e.component,
            worksheet: worksheet,
            autoFilterEnabled: true
        }).then(function () {
            // https://github.com/exceljs/exceljs#writing-xlsx
            workbook.xlsx.writeBuffer().then(function (buffer) {
                saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'Proyectos.xlsx');
            });");
            WriteLiteral("\r\n        });\r\n        e.cancel = true;\r\n    }\r\n\r\n    function grid_dataSource_beforeSend(operation, ajax) {\r\n");
            WriteLiteral("\r\n             ajax.headers = {\r\n            RequestVerificationToken: \"");
#nullable restore
#line 223 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
                                  Write(Xsrf.GetAndStoreTokens(Model.HttpContext).RequestToken);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
        };
    }

      function isAdministrador() {

            isAdmon = verifyRol();

        $(""#GridListado"").dxDataGrid(""instance"").option(""editing.allowAdding"", isAdmon);
        $(""#GridListado"").dxDataGrid(""instance"").option(""editing.allowUpdating"", isAdmon);
          $(""#GridListado"").dxDataGrid(""instance"").option(""editing.allowDeleting"", isAdmon);
       

    }

    function isAdministradorBloques() {
        isAdmon = verifyRol();

        
        $(""#gridBloques"").dxDataGrid(""instance"").option(""editing.allowAdding"", isAdmon);
        $(""#gridBloques"").dxDataGrid(""instance"").option(""editing.allowUpdating"", isAdmon);
        $(""#gridBloques"").dxDataGrid(""instance"").option(""editing.allowDeleting"", isAdmon);
    }

    function verifyRol() {
         var existrole = """);
#nullable restore
#line 248 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
                     Write(User.Claims.FirstOrDefault(c => c.Type.Equals("rol")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        var isAdmon = false;\r\n        if (existrole != \"\") {\r\n            var role = \"");
#nullable restore
#line 251 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Ubicacion\Listado.cshtml"
                   Write(User.Claims.FirstOrDefault(c => c.Type.Equals("rol")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            if (role.toString().includes(\"Administrador\")) { isAdmon = true; }\r\n            else { isAdmon = false; }\r\n        }\r\n        return isAdmon;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevExtremeAspNetCoreResponsiveApp.Pages.Ubicacion.ListadoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Ubicacion.ListadoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Ubicacion.ListadoModel>)PageContext?.ViewData;
        public DevExtremeAspNetCoreResponsiveApp.Pages.Ubicacion.ListadoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
