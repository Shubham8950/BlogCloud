#pragma checksum "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f8622c2953d2906422d66f78a9b5f3e8039233"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Login), @"mvc.1.0.view", @"/Views/Users/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Login.cshtml", typeof(AspNetCore.Views_Users_Login))]
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
#line 1 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Code2Night;

#line default
#line hidden
#line 6 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Code2Night.Models;

#line default
#line hidden
#line 7 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Code2Night.DAL.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f8622c2953d2906422d66f78a9b5f3e8039233", @"/Views/Users/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Login.cshtml"
  
    ViewBag.Title = "Login | Code2Night.com";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(103, 270, true);
            WriteLiteral(@"<div class=""page-intro"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ol class=""breadcrumb"">
                    <li>
                        <i class=""fa fa-home pr-10""></i>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 373, "\"", 407, 1);
#line 13 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Login.cshtml"
WriteAttributeValue("", 380, Url.Action("index","User"), 380, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(408, 2201, true);
            WriteLiteral(@">Home</a>
                    </li>
                    <li class=""active"">Login</li>
                </ol>
            </div>
        </div>
    </div>
</div>
<section class=""main-container"">

    <div class=""container"">
        <div class=""row"">

            <!-- main start -->
            <!-- ================ -->
            <div class=""main object-non-visible"" data-animation-effect=""fadeInDownSmall"" data-effect-delay=""300"">
                <div class=""form-block center-block"">
                    <h1 class=""title"">Login</h1>
                    <hr>
                    <div class=""form-horizontal"">
                        <div class=""form-group has-feedback"">
                            <label for=""inputUserName"" class=""col-sm-3 control-label"">User Name</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"" id=""UserName"" placeholder=""User Name"" required>
                                <i class=""fa fa-user");
            WriteLiteral(@" form-control-feedback""></i>
                                <h3 id=""UserStatus""></h3>
                            </div>
                        </div>
                        <div class=""form-group has-feedback"">
                            <label for=""inputPassword"" class=""col-sm-3 control-label"">Password</label>
                            <div class=""col-sm-8"">
                                <input type=""password"" class=""form-control"" id=""Password"" placeholder=""Password"" required>
                                <i class=""fa fa-lock form-control-feedback""></i>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-3 col-sm-8"">
                                <div class=""checkbox"">
                                    <label>
                                        <input id=""Remember"" type=""checkbox""> Remember me.
                                    </label>
                 ");
            WriteLiteral("               </div>\r\n                                <button type=\"submit\" onclick=\"Login()\" class=\"btn btn-group btn-default btn-sm\">Log In</button>\r\n");
            EndContext();
            BeginContext(3464, 241, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <p class=\"text-center space-top\">\r\n                    Don\'t have an account yet?\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3705, "\"", 3743, 1);
#line 71 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Login.cshtml"
WriteAttributeValue("", 3712, Url.Action("Register","Users"), 3712, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3744, 222, true);
            WriteLiteral(">Sign up</a> now.\r\n                </p>\r\n            </div>\r\n            <!-- main end -->\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n<script>\r\n    var Login=function()\r\n    {\r\n\r\n        var promises = GetAjaxDataPromise(\'");
            EndContext();
            BeginContext(3967, 28, false);
#line 83 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Login.cshtml"
                                      Write(Url.Action("Login", "Users"));

#line default
#line hidden
            EndContext();
            BeginContext(3995, 682, true);
            WriteLiteral(@"', { UserName: $(""#UserName"").val(), Password: $(""#Password"").val(), Remember: $(""#Remember"").is(""checked"") });
        promises.done(function (response) {
            console.log(response);
            if (response[0] === ""0"") {
                console.log(response);
                Swal.fire({
                    position: 'top-center',
                    type: 'info',
                    title: response[1],
                    showConfirmButton: true,
                    timer: 3000
                });
            }
            else {
                var data = response;
                if (data[1] == ""Admin"")
                    window.location.href = '");
            EndContext();
            BeginContext(4678, 37, false);
#line 99 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Login.cshtml"
                                       Write(Url.Action("index", "DashboardGraph"));

#line default
#line hidden
            EndContext();
            BeginContext(4715, 70, true);
            WriteLiteral("\';\r\n                else\r\n                    window.location.href = \'");
            EndContext();
            BeginContext(4786, 28, false);
#line 101 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Login.cshtml"
                                       Write(Url.Action("index", "Users"));

#line default
#line hidden
            EndContext();
            BeginContext(4814, 113, true);
            WriteLiteral("\';\r\n            }\r\n\r\n        });\r\n        promises.fail(function (data) { console.log(data)})\r\n    }\r\n</script>\r\n");
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