#pragma checksum "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d305becb9f8252df084c00b43f18cc711add18d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Injury_PostInjuryLog), @"mvc.1.0.view", @"/Views/Injury/PostInjuryLog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Injury/PostInjuryLog.cshtml", typeof(AspNetCore.Views_Injury_PostInjuryLog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d305becb9f8252df084c00b43f18cc711add18d", @"/Views/Injury/PostInjuryLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Injury_PostInjuryLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Controllers.InjuryController.InputInjuryLogModel>
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
#line 2 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
  
    ViewData["Title"] = "PostInjury";

#line default
#line hidden
            BeginContext(104, 2116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b04b807280064ed591cd2a52ee685661", async() => {
                BeginContext(110, 49, true);
                WriteLiteral("\n    <h1>\n        Post New Injury\n    </h1>\n    \n");
                EndContext();
#line 10 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
 using (Html.BeginForm("PostInjuryLog", "Injury", FormMethod.Post))
{
    

#line default
#line hidden
                BeginContext(234, 23, false);
#line 12 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(258, 40, true);
                WriteLiteral("    <input type=\"hidden\" name=\"InjuryID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 298, "", 320, 1);
#line 13 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
WriteAttributeValue("", 305, Model.InjuryID, 305, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(320, 4, true);
                WriteLiteral(" />\n");
                EndContext();
                BeginContext(329, 42, false);
#line 14 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.ValidationMessageFor(m => m.InjuryID));

#line default
#line hidden
                EndContext();
                BeginContext(373, 44, true);
                WriteLiteral("    <input type=\"hidden\" name=\"RehabOptions\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 417, "", 443, 1);
#line 16 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
WriteAttributeValue("", 424, Model.RehabOptions, 424, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(443, 4, true);
                WriteLiteral(" />\n");
                EndContext();
                BeginContext(452, 46, false);
#line 17 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.ValidationMessageFor(m => m.RehabOptions));

#line default
#line hidden
                EndContext();
                BeginContext(500, 40, true);
                WriteLiteral("    <input type=\"hidden\" name=\"PostedBy\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 540, "", 562, 1);
#line 19 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
WriteAttributeValue("", 547, Model.PostedBy, 547, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(562, 8, true);
                WriteLiteral(" />    \n");
                EndContext();
                BeginContext(575, 42, false);
#line 20 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.ValidationMessageFor(m => m.PostedBy));

#line default
#line hidden
                EndContext();
                BeginContext(619, 33, true);
                WriteLiteral("<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(653, 65, false);
#line 23 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.LabelFor(m=>m.Description, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(718, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(724, 67, false);
#line 24 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.TextAreaFor(m=>m.Description, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(791, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(797, 45, false);
#line 25 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.ValidationMessageFor(m => m.Description));

#line default
#line hidden
                EndContext();
                BeginContext(842, 41, true);
                WriteLiteral("\n</div>\n<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(884, 58, false);
#line 28 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.LabelFor(m=>m.Date, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(942, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(948, 58, false);
#line 29 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.EditorFor(m=>m.Date, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1006, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1012, 38, false);
#line 30 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.ValidationMessageFor(m => m.Date));

#line default
#line hidden
                EndContext();
                BeginContext(1050, 41, true);
                WriteLiteral("\n</div>\n<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(1092, 61, false);
#line 33 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.LabelFor(m=>m.RehabID, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1153, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1159, 61, false);
#line 34 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.EditorFor(m=>m.RehabID, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1220, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1226, 41, false);
#line 35 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.ValidationMessageFor(m => m.RehabID));

#line default
#line hidden
                EndContext();
                BeginContext(1267, 41, true);
                WriteLiteral("\n</div>\n<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(1309, 60, false);
#line 38 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.LabelFor(m=>m.Rating, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1369, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1375, 60, false);
#line 39 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.EditorFor(m=>m.Rating, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1435, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1441, 40, false);
#line 40 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
Write(Html.ValidationMessageFor(m => m.Rating));

#line default
#line hidden
                EndContext();
                BeginContext(1481, 82, true);
                WriteLiteral("\n</div>\n   <button type=\"submit\" class=\"btn btn-primary\">Post Injury Log</button>\n");
                EndContext();
#line 43 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
}

#line default
#line hidden
                BeginContext(1565, 291, true);
                WriteLiteral(@"
<ul class=""list-group"">
    <li class=""list-group-item"">
        <div class=""row"">
            <div class=""col-md-8"">
                <strong>Name</strong>
            </div>
            <div class=""col-md-4"">
                <strong>ID</strong>
            </div>
        </div>
    </li>
");
                EndContext();
#line 56 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
     foreach (var Options in Model.RehabOptions)
    {

#line default
#line hidden
                BeginContext(1911, 126, true);
                WriteLiteral("        <li class=\"list-group-item\">\n            <div class=\"row\">\n                <div class=\"col-md-8\">\n                    ");
                EndContext();
                BeginContext(2038, 12, false);
#line 61 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
               Write(Options.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2050, 83, true);
                WriteLiteral("\n                </div>\n                <div class=\"col-md-4\">\n                    ");
                EndContext();
                BeginContext(2134, 10, false);
#line 64 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
               Write(Options.ID);

#line default
#line hidden
                EndContext();
                BeginContext(2144, 57, true);
                WriteLiteral("\n                </div>\n            </div>\n        </li>\n");
                EndContext();
#line 68 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Injury/PostInjuryLog.cshtml"
    }

#line default
#line hidden
                BeginContext(2207, 6, true);
                WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Controllers.InjuryController.InputInjuryLogModel> Html { get; private set; }
    }
}
#pragma warning restore 1591