#pragma checksum "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5465bf1b5c0630f0902edc95d9478b3f9833a127"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Blogs), @"mvc.1.0.view", @"/Views/Blog/Blogs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Blogs.cshtml", typeof(AspNetCore.Views_Blog_Blogs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5465bf1b5c0630f0902edc95d9478b3f9833a127", @"/Views/Blog/Blogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Blogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.MyBlogs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-right link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
  
    ViewBag.Title = "Blogs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 218, true);
            WriteLiteral("<div class=\"page-intro\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li><i class=\"fa fa-home pr-10\"></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 340, "\"", 375, 1);
#line 11 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
WriteAttributeValue("", 347, Url.Action("Index","Users"), 347, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 55, true);
            WriteLiteral(">Home</a></li>\r\n                    <li class=\"active\">");
            EndContext();
            BeginContext(432, 13, false);
#line 12 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                  Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(445, 321, true);
            WriteLiteral(@"</li>
                </ol>
            </div>
        </div>
    </div>
</div>
<section class=""main-container"">
    <div class=""container"">
        <div class=""row"">
             <div class=""main col-md-12"" >
                    <div>
                    <div id=""lvCandidatestbl""  class=""masonry-grid row"">
");
            EndContext();
#line 24 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                     foreach (var blog in Model.BlogsList)
                    {

#line default
#line hidden
            BeginContext(849, 159, true);
            WriteLiteral("                            <div class=\"masonry-grid-item col-sm-6 col-md-4\" id=\"mydiv\">\r\n                                <article class=\"clearfix blogpost\">\r\n");
            EndContext();
#line 28 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                     if (blog.VideoEmbed != null)
                                    {

#line default
#line hidden
            BeginContext(1114, 131, true);
            WriteLiteral("                                    <div class=\"embed-responsive embed-responsive-16by9\">\r\n                                        ");
            EndContext();
            BeginContext(1246, 25, false);
#line 31 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                   Write(Html.Raw(blog.VideoEmbed));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 33 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1356, 192, true);
            WriteLiteral("                                    <div class=\"blogpost-body\">\r\n                                        <div class=\"post-info\">\r\n                                            <span class=\"day\">");
            EndContext();
            BeginContext(1549, 24, false);
#line 36 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                                         Write(blog.Date.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 73, true);
            WriteLiteral("</span>\r\n                                            <span class=\"month\">");
            EndContext();
            BeginContext(1647, 30, false);
#line 37 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                                           Write(blog.Date.ToString("MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 249, true);
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <div class=\"blogpost-content\">\r\n                                            <header>\r\n                                                <h2 class=\"title\">");
            EndContext();
            BeginContext(1926, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5465bf1b5c0630f0902edc95d9478b3f9833a1278211", async() => {
                BeginContext(2002, 10, false);
#line 41 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                                                                                                                        Write(blog.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1935, "~/Blog/MyBlog?id=", 1935, 17, true);
#line 41 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
AddHtmlAttributeValue("", 1952, System.Web.HttpUtility.UrlEncode(blog.BlogUrl), 1952, 47, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2016, 114, true);
            WriteLiteral("</h2>\r\n                                                <div class=\"sdubmitted\"><i class=\"fa fa-user pr-5\"></i> by ");
            EndContext();
            BeginContext(2130, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5465bf1b5c0630f0902edc95d9478b3f9833a12710270", async() => {
                BeginContext(2187, 15, false);
#line 42 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                                                                                                                                              Write(blog.AuthorName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2139, "~/Blog/Author/", 2139, 14, true);
#line 42 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
AddHtmlAttributeValue("", 2153, blog.AuthorId, 2153, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2167, "-", 2167, 1, true);
#line 42 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
AddHtmlAttributeValue("", 2168, blog.AuthorName, 2168, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2206, 110, true);
            WriteLiteral("</div>\r\n                                            </header>\r\n                                            <p>");
            EndContext();
            BeginContext(2317, 23, false);
#line 44 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                          Write(Html.Raw(blog.BlogBody));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 312, true);
            WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                    <footer class=""clearfix"">
                                        <ul class=""links pull-left"">
                                            <li><i class=""fa fa-tags pr-5""></i>
");
            EndContext();
#line 50 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                             foreach (var str in blog.Tags.Split(',').ToList())
                                            {
                                                if (!string.IsNullOrWhiteSpace(str))
                                                {

#line default
#line hidden
            BeginContext(2933, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(2981, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5465bf1b5c0630f0902edc95d9478b3f9833a12713744", async() => {
                BeginContext(3043, 3, false);
#line 54 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                                                                                        Write(str);

#line default
#line hidden
                EndContext();
                BeginContext(3046, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3049, 101, false);
#line 54 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                                                                                              Write(blog.Tags.Split(',').ToList().IndexOf(str).Equals(blog.Tags.Split(',').ToList().Count - 1) ? "" : ",");

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2990, "~/blog/tags/", 2990, 12, true);
#line 54 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
AddHtmlAttributeValue("", 3002, System.Web.HttpUtility.UrlEncode(str), 3002, 38, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                                                }
                                            }

#line default
#line hidden
            BeginContext(3255, 138, true);
            WriteLiteral("                                            </li>\r\n                                        </ul>\r\n                                        ");
            EndContext();
            BeginContext(3393, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5465bf1b5c0630f0902edc95d9478b3f9833a12716587", async() => {
                BeginContext(3492, 22, true);
                WriteLiteral("<span>Read more</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3426, "~/Blog/MyBlog?id=", 3426, 17, true);
#line 59 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
AddHtmlAttributeValue("", 3443, System.Web.HttpUtility.UrlEncode(blog.BlogUrl), 3443, 47, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3518, 129, true);
            WriteLiteral("\r\n                                    </footer>\r\n                                </article>\r\n                            </div>\r\n");
            EndContext();
#line 63 "E:\BlogCloud\code2night18012021\Views\Blog\Blogs.cshtml"
                    }

#line default
#line hidden
            BeginContext(3670, 182, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div style=\"margin:auto auto\" id=\"pagination\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.DAL.Common.MyBlogs> Html { get; private set; }
    }
}
#pragma warning restore 1591
