#pragma checksum "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea9c516a94c05af9ea9359d92ab1aff8e1c65c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Health_PostBlog), @"mvc.1.0.view", @"/Views/Health/PostBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Health/PostBlog.cshtml", typeof(AspNetCore.Views_Health_PostBlog))]
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
#line 1 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
using Lab8.Areas.Identity.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea9c516a94c05af9ea9359d92ab1aff8e1c65c2", @"/Views/Health/PostBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Health_PostBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Models.HealthModel>
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
            BeginContext(140, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
  
    ViewData["Title"] = "PostBlog";

#line default
#line hidden
            BeginContext(182, 1021, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d9b4c60993475ab825c72eb14f0bd8", async() => {
                BeginContext(188, 44, true);
                WriteLiteral("\n    <h1>\n        Post Health Log\n    </h1>\n");
                EndContext();
#line 13 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
 using (Html.BeginForm("PostBlog", "Health", FormMethod.Post))
{
    

#line default
#line hidden
                BeginContext(302, 23, false);
#line 15 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(326, 40, true);
                WriteLiteral("    <input type=\"hidden\" name=\"PostedBy\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 366, "", 399, 1);
#line 16 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
WriteAttributeValue("", 373, UserMan.GetUserName(User), 373, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(399, 45, true);
                WriteLiteral(" />\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(445, 59, false);
#line 18 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.AName, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(504, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(514, 60, false);
#line 19 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.TextBoxFor(m=>m.AName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(574, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(584, 39, false);
#line 20 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.AName));

#line default
#line hidden
                EndContext();
                BeginContext(623, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(677, 66, false);
#line 23 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.ADescription, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(743, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(753, 68, false);
#line 24 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.TextAreaFor(m=>m.ADescription, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(821, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(831, 46, false);
#line 25 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.ADescription));

#line default
#line hidden
                EndContext();
                BeginContext(877, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(931, 61, false);
#line 28 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.ARating, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(992, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1002, 61, false);
#line 29 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.EditorFor(m=>m.ARating, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1063, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1073, 41, false);
#line 30 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.ARating));

#line default
#line hidden
                EndContext();
                BeginContext(1114, 80, true);
                WriteLiteral("\n    </div>\n   <button type=\"submit\" class=\"btn btn-primary\">Post Blog</button>\n");
                EndContext();
#line 33 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Health/PostBlog.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Models.HealthModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
