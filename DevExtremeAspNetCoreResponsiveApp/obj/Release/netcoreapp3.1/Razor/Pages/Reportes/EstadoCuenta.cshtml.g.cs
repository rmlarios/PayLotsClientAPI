#pragma checksum "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\EstadoCuenta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd8aec245c1417f44413fd6f6425bd14dc1aa1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Reportes_EstadoCuenta), @"mvc.1.0.razor-page", @"/Pages/Reportes/EstadoCuenta.cshtml")]
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
#nullable restore
#line 2 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\EstadoCuenta.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd8aec245c1417f44413fd6f6425bd14dc1aa1a", @"/Pages/Reportes/EstadoCuenta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abefe4e372dfbabd28ca96f5957c69b2cb15bcf5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reportes_EstadoCuenta : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/viewer.part.bundle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\EstadoCuenta.cshtml"
  
    ViewData["Title"] = "Estado de Cuenta";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    function beforeRender(s, e) {\r\n       // s.GetPreviewModel().reportPreview.zoom(1);\r\n    }\r\n\r\n    function error(s,e) {\r\n        alert(e);\r\n    }\r\n</script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1cd8aec245c1417f44413fd6f6425bd14dc1aa1a5129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 20 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\EstadoCuenta.cshtml"
    Write(Html.DevExtreme().Lookup().Placeholder("Seleccione la Asignacion").SearchEnabled(true).SearchMode(DropDownSearchMode.Contains).SearchExpr("DatoCompleto").StylingMode(EditorStylingMode.Outlined).DisplayExpr("DatoCompleto").ValueExpr("IdAsignacion").DataSource(
        c=>c.Mvc().Controller("Asignaciones").LoadAction("GetAll").Key("IdAsignacion")).Value(Model.idselected).DataSourceOptions(o => o.Filter("['Estado', '=', 'Vigente']"))
        //.OnSelectionChanged()
        .OnValueChanged(
         item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n        function(e){\r\n        window.location.href = \"/Reportes/EstadoCuenta?id=\" + e.value;\r\n        }\r\n        ");
    PopWriter();
}
)
        )

    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-8\"></div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 37 "D:\GIT\PayLotsClientAPI\DevExtremeAspNetCoreResponsiveApp\Pages\Reportes\EstadoCuenta.cshtml"
    Write(Html.DevExpress().WebDocumentViewer("Viewer").Height("800px").Bind(Model.rptEstadoCuenta).ClientSideEvents(c=>c.BeforeRender("beforeRender").OnServerError("error"))
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.EstadoCuentaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.EstadoCuentaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.EstadoCuentaModel>)PageContext?.ViewData;
        public DevExtremeAspNetCoreResponsiveApp.Pages.Reportes.EstadoCuentaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
