#pragma checksum "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40f4e251c40cd984ab666710e9adcb97b7d820e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ListaAsignaciones_RegistrarAsignacion), @"mvc.1.0.razor-page", @"/Pages/ListaAsignaciones/RegistrarAsignacion.cshtml")]
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
#line 1 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreResponsiveApp.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40f4e251c40cd984ab666710e9adcb97b7d820e", @"/Pages/ListaAsignaciones/RegistrarAsignacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ccded478ea879bcdad98436fdc08a5ed888fec9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ListaAsignaciones_RegistrarAsignacion : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary fa fa-2x fa-save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Clear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary fa fa-2x fa-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Clear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Clear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"
  
    ViewData["Title"] = "RegistrarAsignacion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 12 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dx-form-group-caption\"><h3>Registrar Asignaciones</h3></div>\r\n    <div class=\"dx-card\" style=\"padding-top:20px;\">\r\n\r\n        <table style=\"margin-left:25px;\">\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"
                Write(Html.DevExtreme().Button().Icon("save").Type(ButtonType.Default).Text("Guardar").HoverStateEnabled(true).StylingMode(ButtonStylingMode.Contained).UseSubmitBehavior(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"
                Write(Html.DevExtreme().Button().Icon("plus").Type(ButtonType.Default).Text("Nuevo").OnClick("newButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"
                Write(Html.DevExtreme().Button().Icon("clear").Type(ButtonType.Default).Text("Cancelar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n\r\n        <div class=\"btn-group-lg text-left\" role=\"toolbar\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f40f4e251c40cd984ab666710e9adcb97b7d820e10185", async() => {
                WriteLiteral(" Guardar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f40f4e251c40cd984ab666710e9adcb97b7d820e11713", async() => {
                WriteLiteral(" Nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f40f4e251c40cd984ab666710e9adcb97b7d820e13265", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 39 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Asignaciones.IdAsignacion);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 41 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"
    Write(Html.DevExtreme().Form<Asignaciones>()
                                                                                        .ID("form")
                                                                                        .ColCount(12)
                                                                                        .FormData(Model.Asignaciones)
                                                                                        .LabelLocation(FormLabelLocation.Top)

                                                                                        .Height("80%")
                                                                                        .Width("100%")
                                                                                        .ScrollingEnabled(true)
                                                                                        .LabelLocation(FormLabelLocation.Left)
                                                                                        .RequiredMark("*")
                                                                                        .ShowColonAfterLabel(true)
                                                                                        .HoverStateEnabled(true)
                                                                                        .ReadOnly(false)
                                                                                        .ShowColonAfterLabel(true)
                                                                                        .Items(items =>
                                                                                        {


                                                                                            items.AddSimpleFor(m => m.IdAsignacion).Editor(e => e.TextBox()).Visible(false);




                                                                                            items.AddSimpleFor(m => m.IdLote).Editor(e => e.SelectBox()
                                                                                                                                                        .StylingMode(EditorStylingMode.Outlined)

                                                                                                                                                        .Height(40)
                                                                                                                                                        .SearchEnabled(true)
                                                                                                                                                        .SearchMode(DropDownSearchMode.Contains)
                                                                                                                                                        .DataSource(d => d.Mvc().Controller("Lotes1").LoadAction("Get").Key("IdLote"))
                                                                                                                                                        .DisplayExpr("NumeroLote")
                                                                                                                                                        .ValueExpr("IdLote")
                                                                                                                                                       .Value(Model.Asignaciones.IdLote)
                                                                                                                                                        .ShowClearButton(true)
                                                                                                                                                        .ShowDropDownButton(true)
                                                                                                                                                        )

                                                                                                                               .ValidationRules(r => r.AddRequired().Message("Debe seleccionar el Lote a Asignar"))
                                                                                                                               .ColSpan(6);

                                                                                            items.AddSimpleFor(m => m.IdBeneficiario).Editor(e => e.SelectBox()
                                                                                                                                                        .SearchEnabled(true)
                                                                                                                                                        .SearchMode(DropDownSearchMode.Contains)
                                                                                                                                                        .StylingMode(EditorStylingMode.Outlined)
                                                                                                                                                        .Height(40)
                                                                                                                                                        .DataSource(d => d.Mvc().Controller("Beneficiarios").LoadAction("Get").Key("IdBeneficiario"))
                                                                                                                                                        .DisplayExpr("NombreCompleto")
                                                                                                                                                        .ValueExpr("IdBeneficiario")
                                                                                                                                                        .Value(Model.Asignaciones.IdBeneficiario)
                                                                                                                                                        .ShowClearButton(true)
                                                                                                                                                        .ShowDropDownButton(true)

                                                                                                                                                        )

                                                                                                                               .ValidationRules(r => r.AddRequired().Message("Debe seleccionar el Beneficiario")).ColSpan(6);


                                                                                            items.AddSimpleFor(m => m.MontoTotal).Editor(e => e.NumberBox().Height(40).StylingMode(EditorStylingMode.Outlined).ShowSpinButtons(true)).ColSpan(4);
                                                                                            items.AddSimpleFor(m => m.FechaInicioPago).Editor(e => e.DateBox().Height(40).StylingMode(EditorStylingMode.Outlined)).ColSpan(4);
                                                                                            items.AddSimpleFor(m => m.CuotaMinima).Editor(e => e.NumberBox().Height(40).StylingMode(EditorStylingMode.Outlined).ShowSpinButtons(true)).ColSpan(4);
                                                                                            items.AddSimpleFor(m => m.Prima).Editor(e => e.NumberBox().Height(40).StylingMode(EditorStylingMode.Outlined).ShowSpinButtons(true)).ColSpan(4);
                                                                                            items.AddSimpleFor(m => m.Donado).ColSpan(1);
                                                                                            items.AddSimpleFor(m => m.AplicaMora).ColSpan(1);
                                                                                            items.AddSimpleFor(m => m.Observaciones).Editor(e => e.TextBox().Height(40).StylingMode(EditorStylingMode.Outlined)).ColSpan(6);
                                                                                            items.AddSimpleFor(m => m.AplicaInteres).ColSpan(4);
                                                                                            items.AddSimpleFor(m => m.TasaInteres).Editor(e => e.NumberBox().Height(40).StylingMode(EditorStylingMode.Outlined).ShowSpinButtons(true)).ColSpan(4);
                                                                                            items.AddSimpleFor(m => m.Plazo).Editor(e => e.NumberBox().Height(40).StylingMode(EditorStylingMode.Outlined).ShowSpinButtons(true)).ColSpan(4);



                                                                                        }
                                                                                        )


        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 119 "D:\Repository\rmlarios\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\ListaAsignaciones\RegistrarAsignacion.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f40f4e251c40cd984ab666710e9adcb97b7d820e24720", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<style>
    #form {
        padding: 10px 10px 110px;
    }
</style>
<script>
    function newButton(e) {
        var buttonText = e.component.option(""text"");
        DevExpress.ui.notify(""The "" + buttonText + "" button was clicked"");
        window.location.href = window.location.href + '/?id=0';
    }

    $(document).ready(function () {

        $(""#save"").click(function () {
            $(""form"").attr(""action"", ""/Home/SaveForm"");
        });

        $(""#cancel"").click(function () {
            $(""form"").attr(""action"", ""/Home/CancelForm"");
        });

    });

</script>

");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevExtremeAspNetCoreResponsiveApp.Pages.ListaAsignaciones.RegistrarAsignacionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.ListaAsignaciones.RegistrarAsignacionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.ListaAsignaciones.RegistrarAsignacionModel>)PageContext?.ViewData;
        public DevExtremeAspNetCoreResponsiveApp.Pages.ListaAsignaciones.RegistrarAsignacionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
