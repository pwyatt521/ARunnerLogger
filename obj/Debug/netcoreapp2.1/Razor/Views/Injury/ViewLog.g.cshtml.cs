#pragma checksum "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/ViewLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e2d464242c8da55abd64f239703c232682ea3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Injury_ViewLog), @"mvc.1.0.view", @"/Views/Injury/ViewLog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Injury/ViewLog.cshtml", typeof(AspNetCore.Views_Injury_ViewLog))]
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
#line 1 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/_ViewImports.cshtml"
using Lab8;

#line default
#line hidden
#line 2 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/_ViewImports.cshtml"
using Lab8.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e2d464242c8da55abd64f239703c232682ea3b", @"/Views/Injury/ViewLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Injury_ViewLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Controllers.InjuryController.LogWithRehab>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8eea30ce59d4983b766f0834c12430a", async() => {
                BeginContext(61, 18, true);
                WriteLiteral("\n    <h1>\n        ");
                EndContext();
                BeginContext(80, 32, false);
#line 4 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/ViewLog.cshtml"
   Write(Html.DisplayFor(m => m.log.Date));

#line default
#line hidden
                EndContext();
                BeginContext(112, 50, true);
                WriteLiteral("\n    </h1>\n    <h3>\n        Description of Rehab: ");
                EndContext();
                BeginContext(163, 39, false);
#line 7 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/ViewLog.cshtml"
                         Write(Html.DisplayFor(m => m.log.Description));

#line default
#line hidden
                EndContext();
                BeginContext(202, 40, true);
                WriteLiteral("\n    </h3>\n    <h3>\n        Rehab Used: ");
                EndContext();
                BeginContext(243, 34, false);
#line 10 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/ViewLog.cshtml"
               Write(Html.DisplayFor(m => m.rehab.Name));

#line default
#line hidden
                EndContext();
                BeginContext(277, 28, true);
                WriteLiteral("\n    </h3>\n    <h3>\n        ");
                EndContext();
                BeginContext(306, 34, false);
#line 13 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/ViewLog.cshtml"
   Write(Html.DisplayFor(m => m.log.Rating));

#line default
#line hidden
                EndContext();
                BeginContext(340, 29, true);
                WriteLiteral("\n        / 10 Pain\n    </h3>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Controllers.InjuryController.LogWithRehab> Html { get; private set; }
    }
}
#pragma warning restore 1591
