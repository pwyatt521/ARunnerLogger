#pragma checksum "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0855984ec5cbd93e7da88fe0e8a43edf22bba4ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Injury_InjuryLogs), @"mvc.1.0.view", @"/Views/Injury/InjuryLogs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Injury/InjuryLogs.cshtml", typeof(AspNetCore.Views_Injury_InjuryLogs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0855984ec5cbd93e7da88fe0e8a43edf22bba4ca", @"/Views/Injury/InjuryLogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Injury_InjuryLogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Controllers.InjuryController.InjuryLogsInputModel>
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
#line 2 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
  
    ViewData["Title"] = "InjuryLogs";

#line default
#line hidden
            BeginContext(105, 1132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df38f2abeca041a29dce2b97c58cf072", async() => {
                BeginContext(111, 416, true);
                WriteLiteral(@"
    <h1>
        Injury Logs for Injury
    </h1>
<ul class=""list-group"">
     <li class=""list-group-item"">
            <div class=""row"">
                <div class=""col-md-10"">
                    <p>
                        Date:
                    </p>
                </div>
                <div class=""col-md-2"">
                    <p>Pain Rating:</p>
                </div>
            </div>
        </li>
");
                EndContext();
#line 22 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
     foreach (var log in Model.logModels)
    {

#line default
#line hidden
                BeginContext(575, 157, true);
                WriteLiteral("        <li class=\"list-group-item\">\n            <div class=\"row\">\n                <div class=\"col-md-10\">\n                    <p>\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 732, "\"", 793, 1);
#line 28 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
WriteAttributeValue("", 739, Url.Action("ViewLog", "Injury", new { @id = log.ID }), 739, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(794, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(796, 8, false);
#line 28 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
                                                                                    Write(log.Date);

#line default
#line hidden
                EndContext();
                BeginContext(804, 118, true);
                WriteLiteral("</a>\n                    </p>\n                </div>\n                <div class=\"col-md-2\">\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 922, "\"", 983, 1);
#line 32 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
WriteAttributeValue("", 929, Url.Action("ViewLog", "Injury", new { @id = log.ID }), 929, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(984, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(986, 10, false);
#line 32 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
                                                                                    Write(log.Rating);

#line default
#line hidden
                EndContext();
                BeginContext(996, 61, true);
                WriteLiteral("</a>\n                </div>\n            </div>\n        </li>\n");
                EndContext();
#line 36 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
    }

#line default
#line hidden
                BeginContext(1063, 47, true);
                WriteLiteral("</ul>\n    <h2>\n        <div>\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1110, "\"", 1179, 1);
#line 40 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/InjuryLogs.cshtml"
WriteAttributeValue("", 1117, Url.Action("PostInjuryLog", "Injury", new { @id = Model.ID }), 1117, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1180, 50, true);
                WriteLiteral(">Post New Injury Log</a>\n        </div>\n    </h2>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Controllers.InjuryController.InjuryLogsInputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
