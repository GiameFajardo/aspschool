#pragma checksum "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e01062915b5adcb25d4b51a3664effd83e198a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumno_Index), @"mvc.1.0.view", @"/Views/Alumno/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alumno/Index.cshtml", typeof(AspNetCore.Views_Alumno_Index))]
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
#line 1 "C:\Users\Chu\Source\Repos\aspplatzi\Views\_ViewImports.cshtml"
using aspplatzi;

#line default
#line hidden
#line 2 "C:\Users\Chu\Source\Repos\aspplatzi\Views\_ViewImports.cshtml"
using aspplatzi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e01062915b5adcb25d4b51a3664effd83e198a3", @"/Views/Alumno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea45552c215b067b37f56a8d9fa669c7cf6b10ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Alumno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ObjetoEscuelaSimple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\Index.cshtml"
  
    ViewData["Title"] = "Alumno";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(83, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(88, 17, false);
#line 7 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 28, true);
            WriteLiteral(" </h1>\r\n\r\n<p>\r\n    Nombre:  ");
            EndContext();
            BeginContext(134, 12, false);
#line 10 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\Index.cshtml"
        Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(146, 12, true);
            WriteLiteral("  \r\n    Id: ");
            EndContext();
            BeginContext(159, 14, false);
#line 11 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\Index.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(173, 12, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n");
            EndContext();
            BeginContext(185, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f78e8bec7da412c9f07733950c0d7df", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 11, true);
            WriteLiteral(" \r\n\r\n<p><i>");
            EndContext();
            BeginContext(235, 20, false);
#line 17 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\Index.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(255, 4, true);
            WriteLiteral(" -  ");
            EndContext();
            BeginContext(260, 17, false);
#line 17 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\Index.cshtml"
                          Write(ViewData["Fecha"]);

#line default
#line hidden
            EndContext();
            BeginContext(277, 8, true);
            WriteLiteral("</i></p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Alumno> Html { get; private set; }
    }
}
#pragma warning restore 1591
