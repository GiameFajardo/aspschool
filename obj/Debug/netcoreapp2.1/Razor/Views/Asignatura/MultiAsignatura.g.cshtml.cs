#pragma checksum "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94653998a4cf8810bd2506931acbcf11d3dd7e85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asignatura_MultiAsignatura), @"mvc.1.0.view", @"/Views/Asignatura/MultiAsignatura.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asignatura/MultiAsignatura.cshtml", typeof(AspNetCore.Views_Asignatura_MultiAsignatura))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94653998a4cf8810bd2506931acbcf11d3dd7e85", @"/Views/Asignatura/MultiAsignatura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea45552c215b067b37f56a8d9fa669c7cf6b10ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Asignatura_MultiAsignatura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Asignatura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "AsignaturaSimple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml"
  
    ViewData["Title"] = "Asignatura";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(97, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(102, 17, false);
#line 7 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 14, true);
            WriteLiteral(" </h1>\r\n\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml"
 foreach (Asignatura asig in Model)
{
    

#line default
#line hidden
            BeginContext(179, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b81308dc6714253ad7f1a46e12f2d4e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 14 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = asig;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
#line 15 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml"
}

#line default
#line hidden
            BeginContext(233, 8, true);
            WriteLiteral("\r\n<p><i>");
            EndContext();
            BeginContext(242, 20, false);
#line 17 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(262, 4, true);
            WriteLiteral(" -  ");
            EndContext();
            BeginContext(267, 17, false);
#line 17 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Asignatura\MultiAsignatura.cshtml"
                          Write(ViewData["Fecha"]);

#line default
#line hidden
            EndContext();
            BeginContext(284, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Asignatura>> Html { get; private set; }
    }
}
#pragma warning restore 1591