#pragma checksum "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea44df9ad21f1cf8e369a09bcbdc9801d75e74d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Asignacion_Registrar), @"mvc.1.0.razor-page", @"/Pages/Asignacion/Registrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea44df9ad21f1cf8e369a09bcbdc9801d75e74d", @"/Pages/Asignacion/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abefe4e372dfbabd28ca96f5957c69b2cb15bcf5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Asignacion_Registrar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "IdAsignacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "IdLoteOld", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml"
  
    ViewData["Title"] = "Registrar Asignación";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml"
 using(Html.BeginForm(method: FormMethod.Post)) 
{


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ea44df9ad21f1cf8e369a09bcbdc9801d75e74d5126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Asignaciones.IdAsignacion);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ea44df9ad21f1cf8e369a09bcbdc9801d75e74d6994", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Asignaciones.IdLote);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml"
Write(Html.DevExtreme().Form<Asignaciones>()
            .ID("form")            
            .ColCount(2)
            .FormData(Model.Asignaciones)
            .LabelLocation(FormLabelLocation.Left)
            .MinColWidth(300)
            .ColCount(4)
            .Height("50%")
            .ReadOnly(false)            
            .ShowColonAfterLabel(true)
            .ShowValidationSummary(true)
            //.Disabled(new JS("disableForm"))
            .Items(item =>{
               item.AddGroup().ColSpan(4).ColCount(6).Items(i => {
                   i.AddButton().Name("Guardar").ColSpan(1).ButtonOptions(o=>o.Icon("save").Text("Guardar").Type(ButtonType.Success).UseSubmitBehavior(true).Width("100%"));

                   i.AddButton().Name("Nuevo").ColSpan(1).ButtonOptions(o=>o.Icon("fa fa-file-o").Text("Nuevo").Type(ButtonType.Success).Width("100%").OnClick(
                       item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                           function(e)
                           {                             
                              
                               window.location.href=""/Asignacion/Registrar/?p="" + 0 ;
                           }
                       ");
    PopWriter();
}
)
                   ));
                   i.AddButton().Name("Cancelar").ColSpan(1).ButtonOptions(o=>o.Icon("").Text("Cancelar").Type(ButtonType.Success).Width("100%").OnClick(
                       item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                           function(e)\r\n                           {\r\n                               window.location.reload();\r\n                           }\r\n                       ");
    PopWriter();
}
)
                   ));
               });
               /*item.AddButton().Name("Guardar").ButtonOptions(o => o.Icon("save").Text("Guardar").Type(ButtonType.Success).UseSubmitBehavior(true));*/
               item.AddSimpleFor(m => m.IdAsignacion).Visible(false);
               item.AddSimpleFor(m=>m.Estado).Visible(false);
               item.AddSimpleFor(m => m.IdLote).ColSpan(2).Label(l => l.Text("Seleccione el lote")).Editor(e => e.Lookup().DataSource(d => d.Mvc().Controller("Lotes").LoadAction("GetAll").Key("IdLote")).DataSourceOptions(o=>o.Filter("[['Estado', '=', 'Disponible'],'or',['IdLote','=',document.getElementsByName('IdLoteOld')[0].value]]"
               ))
               .SearchExpr("NombreLote").SearchMode(DropDownSearchMode.Contains).DisplayExpr(new JS("lookupExpr")).ValueExpr("IdLote").PageLoadingText("Cargando").NextButtonText("Más").PageLoadMode(ListPageLoadMode.NextButton).SearchEnabled(true).SearchMode(DropDownSearchMode.Contains).StylingMode(EditorStylingMode.Outlined)               
               );
               
               item.AddSimpleFor(m => m.IdBeneficiario).ColSpan(2).Label(l => l.Text("Seleccione el beneficiario")).IsRequired(true).Editor(e => e.Lookup().DataSource(d => d.Mvc().Controller("Beneficiarios").LoadAction("GetAll").Key("IdBeneficiario")).DisplayExpr("NombreCompleto").ValueExpr("IdBeneficiario").SearchEnabled(true).SearchMode(DropDownSearchMode.Contains).StylingMode(EditorStylingMode.Outlined)               
               );

               item.AddSimpleFor(m => m.MontoTotal).ColSpan(1).Label(l => l.Text("Valor del Lote")).Editor(e=>e.NumberBox().ShowSpinButtons(true).Mode(NumberBoxMode.Number).Format("$ #,##0.##").StylingMode(EditorStylingMode.Outlined));

               item.AddSimpleFor(m => m.FechaInicioPago).ColSpan(1).Label(l => l.Text("Fecha de Incio de Pago")).Editor(e => e.DateBox().DisplayFormat("dd/MM/yyyy").StylingMode(EditorStylingMode.Outlined));
               
               item.AddSimpleFor(m => m.CuotaMinima).Name("CuotaMinima").ColSpan(1).Label(l => l.Text("Cuota Mínima")).Editor(e=>e.NumberBox().ShowSpinButtons(true).Mode(NumberBoxMode.Number).Format("$ #,##0.##").StylingMode(EditorStylingMode.Outlined));
               
               item.AddSimpleFor(m => m.Prima).ColSpan(1).Editor(e=>e.NumberBox().ShowSpinButtons(true).Mode(NumberBoxMode.Number).Format("$ #,##0.##").StylingMode(EditorStylingMode.Outlined).Min(0));              
               item.AddSimpleFor(m => m.Donado).ColSpan(1);
               item.AddSimpleFor(m => m.AplicaMora).ColSpan(1).Label(l => l.Text("Aplicar Mora"));
               item.AddSimpleFor(m => m.AplicaInteres).ColSpan(1).Label(l => l.Text("Aplicar interés")).Editor(e=>e.CheckBox().OnValueChanged("chkInteresChanged"));
               item.AddSimpleFor(m => m.TasaInteres).ColSpan(1).Label(l => l.Text("Tasa de Interés")).Editor(e=>e.NumberBox().ShowSpinButtons(true).Mode(NumberBoxMode.Number).Format("% #,##0.##").StylingMode(EditorStylingMode.Outlined));
               item.AddSimpleFor(m => m.Plazo).ColSpan(1).Editor(e=>e.NumberBox().ShowSpinButtons(true).Mode(NumberBoxMode.Number).Format("#,##0").StylingMode(EditorStylingMode.Outlined));
               item.AddSimpleFor(m => m.Observaciones).ColSpan(3).Editor(e=>e.TextArea().StylingMode(EditorStylingMode.Outlined));

            }).OnInitialized("onFormInitialized").OnContentReady("onFormReady")
        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml"
          

 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 79 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Asignacion\Registrar.cshtml"
Write(Html.DevExtreme().DataGrid<Asignacion_PlandePago>
                    ()
                    .ID("GridListado")
                    .DataSource(d=>d.Mvc().Controller("Pagos")//.Key("IdAsignacion")
                    //.LoadMethod("Plan")
                    .LoadAction("GetPlan")                    
                    .LoadParams(new { idasignacion = new JS("getIdAsignacion") })                                       
                    )
                    .ColumnResizingMode(ColumnResizingMode.NextColumn)           
                    .NoDataText("No hay registros que mostrar")
                    .ShowBorders(true)
                    .ElementAttr(new { @class = "dx-card wide-card" })
                    .Export(e => e.Enabled(true)).OnExporting("exporting")
                    .Paging(pag => pag.PageSize(6))
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
                    .Columns(c =>{
                        c.AddFor(m => m.NumeroCuota);
                        c.AddFor(m=>m.MesPagado);
                        c.AddFor(m=>m.MontoMinimo);
                        c.AddFor(m=>m.FechaCuota).DataType(GridColumnDataType.Date).Format("dd/MM/yyyy");
                        c.AddFor(m=>m.MontoPagado);
                        c.AddFor(m=>m.Interes);
                        c.AddFor(m=>m.Mora);
                        c.AddFor(m=>m.FechaPago);
                        c.AddFor(m=>m.Saldo);
                        c.AddFor(m=>m.Estado);
                    })
                   
                    .HeaderFilter(h => h.AllowSearch(true).Visible(true))
                    /*Configuracion para la edicion*/
                    .Editing(e => e.Mode(GridEditMode.Popup)
                        .UseIcons(true)
                        .AllowAdding(false)
                        .AllowUpdating(false)
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
                                
                                
                            }))
                          )
                       .ErrorRowEnabled(true)
                      
);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




 <script>
var vform,isFirstLoad=true;

 function onFormInitialized(e) {
        vform = e.component;        
    }

    function onFormReady(e) {
        if (isFirstLoad) {
            var aplicainteres = vform.getEditor(""AplicaInteres"").option(""value"") == null ? false : vform.getEditor(""AplicaInteres"").option(""value"");
            vform.getEditor(""CuotaMinima"").option(""disabled"", aplicainteres);
            vform.getEditor(""Plazo"").option(""disabled"", !aplicainteres);
            vform.getEditor(""TasaInteres"").option(""disabled"", !aplicainteres);
            isFirstLoad = false;
            var estado = vform.option(""formData"").Estado;
            if (estado == ""Anulada"") {
                vform.option(""readOnly"", true);
                vform.getEditor(""Guardar"").option(""disabled"", true);
            }
            else {
                vform.option(""readOnly"", false);
                vform.getEditor(""Guardar"").option(""disabled"", false);
            }

            var queryPar");
            WriteLiteral(@"ams = new URLSearchParams(window.location.search);            
            IdAsignacion = vform.option(""formData"").IdAsignacion;            
            queryParams.set(""p"", IdAsignacion.toString());
            // Replace current querystring with the new one.
            history.replaceState(null, null, ""?"" + queryParams.toString());


        }}

function disableForm(){
    var estado = vform.option(""formData"").Estado;   
}

    function chkInteresChanged(e){
        vform.getEditor(""CuotaMinima"").option(""disabled"", e.value);
        vform.getEditor(""CuotaMinima"").option(""value"", 0);
        //vform.getEditor(""CuotaMinima"").option(""isValid"", e.value);
        //vform.getEditor(""CuotaMinima"").option(""validationStatus"",""valid"");
        vform.getEditor(""Plazo"").option(""disabled"", !e.value);
        vform.getEditor(""Plazo"").option(""value"", 0);
        //vform.getEditor(""Plazo"").option(""isValid"", e.value);
        vform.getEditor(""TasaInteres"").option(""disabled"", !e.value);
        vform.g");
            WriteLiteral(@"etEditor(""TasaInteres"").option(""value"", 0);
        //vform.getEditor(""Plazo"").option(""isValid"", e.value);
        //vform.itemOption(""CuotaMinima"",""isrequired"",!e.value);
    }

    function lookupExpr(item) {
      if(item!=null)
        return item.NombreProyecto + "" "" + item.NombreLote;      
    }

    function filterLote(itemData){
        alert(itemData.Estado);
    }

    function getIdAsignacion(){
        var r = $(""#form"").dxForm(""option"", ""formData"").IdAsignacion;        
        return r;
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
                saveAs(new Blob([");
            WriteLiteral("buffer], { type: \'application/octet-stream\' }), \'PlandePago.xlsx\');\r\n            });\r\n        });\r\n        e.cancel = true;\r\n    }   \r\n\r\n   \r\n        </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevExtremeAspNetCoreResponsiveApp.Pages.Asignacion.RegistrarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Asignacion.RegistrarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Asignacion.RegistrarModel>)PageContext?.ViewData;
        public DevExtremeAspNetCoreResponsiveApp.Pages.Asignacion.RegistrarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
