#pragma checksum "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c306c014b22ccc1c1f7a6641b811bb2ab196e0d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOut_PostBlog), @"mvc.1.0.view", @"/Views/WorkOut/PostBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkOut/PostBlog.cshtml", typeof(AspNetCore.Views_WorkOut_PostBlog))]
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
#line 1 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
using Lab8.Areas.Identity.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c306c014b22ccc1c1f7a6641b811bb2ab196e0d9", @"/Views/WorkOut/PostBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOut_PostBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Models.WorkOutModel>
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
            BeginContext(141, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
  
    ViewData["Title"] = "PostWorkout";

#line default
#line hidden
            BeginContext(186, 1251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a8462966201446a8894262afc7cb822", async() => {
                BeginContext(192, 41, true);
                WriteLiteral("\n    <h1>\n        Post Workout\n    </h1>\n");
                EndContext();
#line 13 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
 using (Html.BeginForm("PostBlog", "WorkOut", FormMethod.Post))
{
    

#line default
#line hidden
                BeginContext(304, 23, false);
#line 15 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(328, 40, true);
                WriteLiteral("    <input type=\"hidden\" name=\"PostedBy\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 368, "", 401, 1);
#line 16 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
WriteAttributeValue("", 375, UserMan.GetUserName(User), 375, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(401, 4, true);
                WriteLiteral(" />\n");
                EndContext();
                BeginContext(406, 41, true);
                WriteLiteral("    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(448, 59, false);
#line 19 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WName, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(507, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(517, 60, false);
#line 20 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.TextBoxFor(m=>m.WName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(577, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(587, 39, false);
#line 21 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WName));

#line default
#line hidden
                EndContext();
                BeginContext(626, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(680, 66, false);
#line 24 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WDescription, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(746, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(756, 68, false);
#line 25 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.TextAreaFor(m=>m.WDescription, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(824, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(834, 46, false);
#line 26 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WDescription));

#line default
#line hidden
                EndContext();
                BeginContext(880, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(934, 61, false);
#line 29 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WRating, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(995, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1005, 61, false);
#line 30 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.EditorFor(m=>m.WRating, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1066, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1076, 41, false);
#line 31 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WRating));

#line default
#line hidden
                EndContext();
                BeginContext(1117, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(1171, 59, false);
#line 34 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WDate, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1230, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1240, 59, false);
#line 35 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.EditorFor(m=>m.WDate, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1299, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1309, 39, false);
#line 36 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WDate));

#line default
#line hidden
                EndContext();
                BeginContext(1348, 80, true);
                WriteLiteral("\n    </div>\n   <button type=\"submit\" class=\"btn btn-primary\">Post Blog</button>\n");
                EndContext();
#line 39 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/WorkOut/PostBlog.cshtml"
}

#line default
#line hidden
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
        public UserManager<Lab8Model> UserMan { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Models.WorkOutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
