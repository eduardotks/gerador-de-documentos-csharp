#pragma checksum "C:\Users\DEV\OneDrive\Área de Trabalho\gerador de documentos projeto\gerador-de-documentos-csharp\SistemaWeb\Views\GeraDocumentos\TelaGeraWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af5e396f224fd5efc67c1a7231b6b4768eb2c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeraDocumentos_TelaGeraWord), @"mvc.1.0.view", @"/Views/GeraDocumentos/TelaGeraWord.cshtml")]
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
#line 1 "C:\Users\DEV\OneDrive\Área de Trabalho\gerador de documentos projeto\gerador-de-documentos-csharp\SistemaWeb\Views\_ViewImports.cshtml"
using SistemaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DEV\OneDrive\Área de Trabalho\gerador de documentos projeto\gerador-de-documentos-csharp\SistemaWeb\Views\_ViewImports.cshtml"
using SistemaWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af5e396f224fd5efc67c1a7231b6b4768eb2c87", @"/Views/GeraDocumentos/TelaGeraWord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a53bc6feecd5773711d9072eb298612b1e39c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_GeraDocumentos_TelaGeraWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/gera_word.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DEV\OneDrive\Área de Trabalho\gerador de documentos projeto\gerador-de-documentos-csharp\SistemaWeb\Views\GeraDocumentos\TelaGeraWord.cshtml"
  
    ViewData["Title"] = "Gera Word";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Gera Word</h4>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js\"></script>\r\n<!-- Cadastro de carros por ex -->\r\n<div>\r\n    <input type=\"button\" value=\"Gerar\" onclick=\"gerarWord()\" />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af5e396f224fd5efc67c1a7231b6b4768eb2c874540", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"modeloId\">Código</label>\r\n                    <input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 505, "\"", 513, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""modeloID"" placeholder=""..."" ng-model=""modeloID"" required/>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""form-group"">
                    <label for=""modeloNome"">Nome</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 818, "\"", 826, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""modeloNome"" ng-model=""modeloNome"" required />
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""form-group"">
                    <label for=""modeloMarca"">Marca</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1120, "\"", 1128, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""modeloMarca""  ng-model=""modeloMarca"" required/>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""form-group"">
                    <label for=""modeloAno"">Ano</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1420, "\"", 1428, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"modeloAno\" ng-model=\"modeloAno\" required />\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af5e396f224fd5efc67c1a7231b6b4768eb2c877724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function createDocument() {
        let data = {
            modeloID: document.getElementById(""modeloID"").value,
            modeloNome: document.getElementById(""modeloNome"").value,
            modeloMarca: document.getElementById(""modeloMarca"").value,
            modeloAno: document.getElementById(""modeloAno"").value
        };
        
        &ajax({
            url: ""GeraDocumentos/criaDocumentoWord"",
            type: ""POST"",
            data: data,
            success: function (data) {
                console.log(data);
            }
        });

</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
