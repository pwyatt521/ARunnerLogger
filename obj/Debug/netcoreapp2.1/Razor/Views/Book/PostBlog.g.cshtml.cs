#pragma checksum "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97349e9613de53b0b7c2ba073582753bfa4b52ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_PostBlog), @"mvc.1.0.view", @"/Views/Book/PostBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/PostBlog.cshtml", typeof(AspNetCore.Views_Book_PostBlog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97349e9613de53b0b7c2ba073582753bfa4b52ac", @"/Views/Book/PostBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_PostBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Models.BookModel>
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
#line 2 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
  
    ViewData["Title"] = "PostBlog";

#line default
#line hidden
            BeginContext(70, 1492, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc56e3b3465b4b1296110c9abeaaac90", async() => {
                BeginContext(76, 43, true);
                WriteLiteral("\n    <h1>\n        Post Blog\n    </h1>\n    \n");
                EndContext();
#line 10 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
 using (Html.BeginForm("PostBlog", "Book", FormMethod.Post))
{
    

#line default
#line hidden
                BeginContext(187, 23, false);
#line 12 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(216, 62, false);
#line 13 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.PostedBy, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(284, 63, false);
#line 14 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.TextBoxFor(m=>m.PostedBy, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(353, 42, false);
#line 15 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.PostedBy));

#line default
#line hidden
                EndContext();
                BeginContext(396, 33, true);
                WriteLiteral("<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(430, 60, false);
#line 17 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.BTitle, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(490, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(496, 61, false);
#line 18 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.TextBoxFor(m=>m.BTitle, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(557, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(563, 40, false);
#line 19 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.BTitle));

#line default
#line hidden
                EndContext();
                BeginContext(603, 41, true);
                WriteLiteral("\n</div>\n<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(645, 61, false);
#line 22 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.BAuthor, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(706, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(712, 62, false);
#line 23 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.TextBoxFor(m=>m.BAuthor, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(774, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(780, 41, false);
#line 24 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.BAuthor));

#line default
#line hidden
                EndContext();
                BeginContext(821, 41, true);
                WriteLiteral("\n</div>\n<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(863, 62, false);
#line 27 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.BSummary, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(925, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(931, 64, false);
#line 28 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.TextAreaFor(m=>m.BSummary, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(995, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1001, 42, false);
#line 29 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.BSummary));

#line default
#line hidden
                EndContext();
                BeginContext(1043, 41, true);
                WriteLiteral("\n</div>\n<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(1085, 61, false);
#line 32 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.BRating, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1146, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1152, 61, false);
#line 33 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.EditorFor(m=>m.BRating, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1213, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1219, 41, false);
#line 34 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.BRating));

#line default
#line hidden
                EndContext();
                BeginContext(1260, 41, true);
                WriteLiteral("\n</div>\n<div class=\"form-group\">    \n    ");
                EndContext();
                BeginContext(1302, 61, false);
#line 37 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.BLength, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1363, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1369, 61, false);
#line 38 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.EditorFor(m=>m.BLength, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1430, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1436, 41, false);
#line 39 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.BLength));

#line default
#line hidden
                EndContext();
                BeginContext(1477, 76, true);
                WriteLiteral("\n</div>\n   <button type=\"submit\" class=\"btn btn-primary\">Post Blog</button>\n");
                EndContext();
#line 42 "/Users/paulwyatt/Desktop/ARunnerLogger/ARunnerLogger/Views/Book/PostBlog.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Models.BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591