#pragma checksum "E:\BlogCloud\code2night18012021\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd279852429057fd55712b56246b6ed662073b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "E:\BlogCloud\code2night18012021\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "E:\BlogCloud\code2night18012021\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "E:\BlogCloud\code2night18012021\Views\_ViewImports.cshtml"
using Code2Night;

#line default
#line hidden
#line 6 "E:\BlogCloud\code2night18012021\Views\_ViewImports.cshtml"
using Code2Night.Models;

#line default
#line hidden
#line 7 "E:\BlogCloud\code2night18012021\Views\_ViewImports.cshtml"
using Code2Night.DAL.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd279852429057fd55712b56246b6ed662073b3", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Web.Mvc.HandleErrorInfo>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BlogCloud\code2night18012021\Views\Shared\Error.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(93, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(120, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd279852429057fd55712b56246b6ed662073b33856", async() => {
                BeginContext(126, 230, true);
                WriteLiteral("\r\n\r\n    <script data-ad-client=\"ca-pub-2622840091485569\" async src=\"https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js\"></script>\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Error</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(363, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(365, 1723, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd279852429057fd55712b56246b6ed662073b35286", async() => {
                BeginContext(371, 544, true);
                WriteLiteral(@"
    <div class=""page-wrapper"">

        <!-- header-top start (Add ""dark"" class to .header-top in order to enable dark header-top e.g <div class=""header-top dark"">) -->
        <!-- ================ -->
        <!-- page-intro start-->
        <!-- ================ -->
        <div class=""page-intro"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <ol class=""breadcrumb"">
                            <li><i class=""fa fa-home pr-10""></i><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 915, "\"", 950, 1);
#line 27 "E:\BlogCloud\code2night18012021\Views\Shared\Error.cshtml"
WriteAttributeValue("", 922, Url.Action("Index","Users"), 922, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(951, 878, true);
                WriteLiteral(@">Home</a></li>
                            <li class=""active"">Error 404</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <!-- page-intro end -->
        <!-- main-container start -->
        <!-- ================ -->
        <section class=""main-container"">

            <div class=""container"">
                <div class=""row"">

                    <!-- main start -->
                    <!-- ================ -->
                    <div class=""main col-md-6 col-md-offset-3"">
                        <h1 class=""title"">Ooops! Page Not Found - 404</h1>
                        <br>
                        <p>The requested URL was not found on this server. Make sure that the Web site address displayed in the address bar of your browser is spelled and formatted correctly or <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1829, "\"", 1863, 1);
#line 47 "E:\BlogCloud\code2night18012021\Views\Shared\Error.cshtml"
WriteAttributeValue("", 1836, Url.Action("index","Blog"), 1836, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1864, 217, true);
                WriteLiteral(">return to Home page.</a></p>\r\n\r\n                    </div>\r\n                    <!-- main end -->\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n        <!-- main-container end -->\r\n\r\n    </div>\r\n");
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
            BeginContext(2088, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Web.Mvc.HandleErrorInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
