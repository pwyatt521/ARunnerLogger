#pragma checksum "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbea5b118db50d12ad70586e74b4cdfd42cf7c42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOut_Index), @"mvc.1.0.view", @"/Views/WorkOut/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkOut/Index.cshtml", typeof(AspNetCore.Views_WorkOut_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbea5b118db50d12ad70586e74b4cdfd42cf7c42", @"/Views/WorkOut/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOut_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WorkOutModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
  
    ViewData["Title"] = "TrainingLogs";

#line default
#line hidden
            BeginContext(82, 1355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a50c04cecc644bb9e5c922995b79d60", async() => {
                BeginContext(88, 75, true);
                WriteLiteral("\r\n    <h1>\r\n        Training Logs\r\n    </h1>\r\n    <h2>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(163, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401c931510c64623983844d4790ba53f", async() => {
                    BeginContext(225, 12, true);
                    WriteLiteral("Post Workout");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(241, 52, true);
                WriteLiteral("\r\n    </div>\r\n    </h2>\r\n\r\n<ul class=\"list-group\">\r\n");
                EndContext();
#line 16 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
     foreach (var WorkOut in Model)
    {

#line default
#line hidden
                BeginContext(337, 160, true);
                WriteLiteral("        <li class=\"list-group-item\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <p>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 497, "\"", 560, 1);
#line 22 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
WriteAttributeValue("", 504, Url.Action("View", "WorkOut", new { @id = WorkOut.ID }), 504, 56, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(561, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(563, 12, false);
#line 22 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
                                                                                      Write(WorkOut.Name);

#line default
#line hidden
                EndContext();
                BeginContext(575, 145, true);
                WriteLiteral("</a>\r\n                    </p>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <p>\r\n                        ");
                EndContext();
                BeginContext(721, 12, false);
#line 27 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
                   Write(WorkOut.Date);

#line default
#line hidden
                EndContext();
                BeginContext(733, 141, true);
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    <p>\r\n                        ");
                EndContext();
                BeginContext(875, 14, false);
#line 32 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
                   Write(WorkOut.Rating);

#line default
#line hidden
                EndContext();
                BeginContext(889, 112, true);
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    ");
                EndContext();
                BeginContext(1001, 352, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49f9605b5e344a27ac5a471ff8787da6", async() => {
                    BeginContext(1087, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(1114, 23, false);
#line 37 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(1137, 56, true);
                    WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1193, "\"", 1212, 1);
#line 38 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"
WriteAttributeValue("", 1201, WorkOut.ID, 1201, 11, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1213, 133, true);
                    WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger\"><i class=\"fas fa-times\"></i></button>\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1353, 61, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
                EndContext();
#line 44 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/Index.cshtml"

    }

#line default
#line hidden
                BeginContext(1423, 7, true);
                WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WorkOutModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
