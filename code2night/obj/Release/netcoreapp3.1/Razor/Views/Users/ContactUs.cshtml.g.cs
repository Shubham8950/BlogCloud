#pragma checksum "E:\blogCloudGit\BlogCloud\code2night\Views\Users\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7999165f11ac1c36dfc203b25cae206e1df8d5a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ContactUs), @"mvc.1.0.view", @"/Views/Users/ContactUs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/ContactUs.cshtml", typeof(AspNetCore.Views_Users_ContactUs))]
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
#line 1 "E:\blogCloudGit\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "E:\blogCloudGit\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "E:\blogCloudGit\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Code2Night;

#line default
#line hidden
#line 6 "E:\blogCloudGit\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Code2Night.Models;

#line default
#line hidden
#line 7 "E:\blogCloudGit\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Code2Night.DAL.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7999165f11ac1c36dfc203b25cae206e1df8d5a2", @"/Views/Users/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom-clear form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\ContactUs.cshtml"
  
    ViewBag.Title = "ContactUs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 218, true);
            WriteLiteral("<div class=\"page-intro\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li><i class=\"fa fa-home pr-10\"></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 308, "\"", 343, 1);
#line 11 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\ContactUs.cshtml"
WriteAttributeValue("", 315, Url.Action("Index","Users"), 315, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(344, 55, true);
            WriteLiteral(">Home</a></li>\r\n                    <li class=\"active\">");
            EndContext();
            BeginContext(400, 13, false);
#line 12 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\ContactUs.cshtml"
                                  Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(413, 642, true);
            WriteLiteral(@"</li>
                </ol>
            </div>
        </div>
    </div>
</div>
<!-- ================ -->
<div class=""section parallax dark-translucent-bg parallax-bg-2"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <h2 class=""title"">Code2night</h2>
                <ul class=""list"">
                    <li><strong></strong></li>
                    <li><i class=""fa fa-home pr-10""></i> #2637,Sector 67 <br><span class=""pl-20"">Kurukshetra, Haryana</span></li>
                    <li><i class=""fa fa-phone pr-10""></i><abbr title=""Phone""></abbr> +91 9034589555</li>
");
            EndContext();
            BeginContext(1170, 873, true);
            WriteLiteral(@"                    <li><i class=""fa fa-envelope pr-10""></i><a href=""mailto:info@Code2night.com"">info@CodeTonight.com</a></li>
                </ul>
                <ul class=""social-links colored circle large"" style=""display:none"">
                    <li class=""facebook""><a target=""_blank"" href=""http://www.facebook.com/""><i class=""fa fa-facebook""></i></a></li>
                    <li class=""twitter""><a target=""_blank"" href=""http://www.twitter.com/""><i class=""fa fa-twitter""></i></a></li>
                    <li class=""googleplus""><a target=""_blank"" href=""http://plus.google.com/""><i class=""fa fa-google-plus""></i></a></li>
                </ul>
            </div>
            <div class=""col-sm-8"">
                <h2 class=""title"">Subscribe</h2>
                <p class=""lead"">For getting latest updates reminders subscribe with us</p>
                ");
            EndContext();
            BeginContext(2043, 546, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7999165f11ac1c36dfc203b25cae206e1df8d5a27150", async() => {
                BeginContext(2089, 493, true);
                WriteLiteral(@"
                    <div class=""form-group has-feedback"">
                        <label class=""sr-only"" for=""subscribe"">Email address</label>
                        <input type=""email"" class=""form-control"" id=""subscribe"" placeholder=""Enter email"" name=""subscribe"" required>
                        <i class=""fa fa-envelope form-control-feedback""></i>
                    </div>
                    <button type=""submit"" class=""btn btn-default btn-sm"">Submit</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2589, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
