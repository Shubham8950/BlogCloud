#pragma checksum "E:\BlogCloud\code2night18012021\Views\SiteMap\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ecac7519d6a4b807c9ecfcf4bf86b9e9d2e2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SiteMap_index), @"mvc.1.0.view", @"/Views/SiteMap/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SiteMap/index.cshtml", typeof(AspNetCore.Views_SiteMap_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ecac7519d6a4b807c9ecfcf4bf86b9e9d2e2c0", @"/Views/SiteMap/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_SiteMap_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\BlogCloud\code2night18012021\Views\SiteMap\index.cshtml"
  
    ViewBag.Title = "index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(91, 59, true);
            WriteLiteral("<div style=\"padding:50px;\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 150, "\'", 197, 1);
#line 7 "E:\BlogCloud\code2night18012021\Views\SiteMap\index.cshtml"
WriteAttributeValue("", 157, Url.Action("GenerateSiteMap","SiteMap"), 157, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(198, 23, true);
            WriteLiteral(">Generate SiteMap</a>\r\n");
            EndContext();
#line 8 "E:\BlogCloud\code2night18012021\Views\SiteMap\index.cshtml"
     if (ViewBag.IsFileAvailable)
    {

#line default
#line hidden
            BeginContext(263, 60, true);
            WriteLiteral("        <a class=\"btn btn-primary\" style=\"margin-left:10px;\"");
            EndContext();
            BeginWriteAttribute("href", "  href=\'", 323, "\'", 368, 1);
#line 10 "E:\BlogCloud\code2night18012021\Views\SiteMap\index.cshtml"
WriteAttributeValue("", 331, Url.Action("DownloadFile","SiteMap"), 331, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(369, 23, true);
            WriteLiteral(">Download SiteMap</a>\r\n");
            EndContext();
#line 11 "E:\BlogCloud\code2night18012021\Views\SiteMap\index.cshtml"
    }

#line default
#line hidden
            BeginContext(399, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
