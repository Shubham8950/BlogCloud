#pragma checksum "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc8685b87c2241508b1543477135c00217ff52d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Tags), @"mvc.1.0.view", @"/Views/Blog/Tags.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Tags.cshtml", typeof(AspNetCore.Views_Blog_Tags))]
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
#line 1 "E:\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "E:\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "E:\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Code2Night;

#line default
#line hidden
#line 6 "E:\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Code2Night.Models;

#line default
#line hidden
#line 7 "E:\BlogCloud\code2night\Views\_ViewImports.cshtml"
using Code2Night.DAL.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8685b87c2241508b1543477135c00217ff52d3", @"/Views/Blog/Tags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Tags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.MyBlogs>
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
#line 2 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
  
    ViewBag.Title = (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author)+ " Blogs | Code2Night.com";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.MetaDescription = "Welcome To Code2night, check out latest programming blogs with detailed description to help you out";
    ViewBag.MetaKeywords = "Code2Night,Code,Programming,Tutorials," + (!string.IsNullOrEmpty(Model.Tag)?Model.Tag:Model.Author);
    ViewBag.Canonical = "https://www.code2night.com/Blog/"+ (!string.IsNullOrEmpty(Model.Tag) ? "Tags" : "Author") + "/"+ (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author);

    ViewBag.OpenGraphUrl = "https://www.code2night.com/Blog/" + (!string.IsNullOrEmpty(Model.Tag) ? "Tags" : "Author") + "/" + (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author);
    ViewBag.OpenGraphDescription = "Welcome To Code2night, check out latest programming blogs with detailed description to help you out";
    ViewBag.OpenGraphTitle = (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author) + " Blogs | Code2Night.com";

#line default
#line hidden
            BeginContext(1106, 419, true);
            WriteLiteral(@"<link href=""https://cdn.bootcss.com/simplePagination.js/1.6/simplePagination.css"" rel=""stylesheet"">
<script src=""https://cdn.bootcss.com/simplePagination.js/1.6/jquery.simplePagination.js""></script>
<div class=""page-intro"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ol class=""breadcrumb"">
                    <li><i class=""fa fa-home pr-10""></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1525, "\"", 1560, 1);
#line 20 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
WriteAttributeValue("", 1532, Url.Action("Index","Users"), 1532, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1561, 75, true);
            WriteLiteral(">Home</a></li>\r\n                    <li >Blogs    </li> <li class=\"active\">");
            EndContext();
            BeginContext(1638, 49, false);
#line 21 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                       Write(!string.IsNullOrEmpty(Model.Tag)?"Tags":"Authors");

#line default
#line hidden
            EndContext();
            BeginContext(1688, 341, true);
            WriteLiteral(@"
                   </li>
                </ol>
            </div>
        </div>
    </div>
</div>
<section class=""main-container"">

    <div class=""container"">
        <div class=""row"">
            <div class=""main col-md-12"">

                <!-- page-title start from here -->
                <!-- ================ -->

");
            EndContext();
#line 37 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                 if (!string.IsNullOrEmpty(Model.Tag))
                {

#line default
#line hidden
            BeginContext(2104, 145, true);
            WriteLiteral("                <h1 class=\"page-title\">Blog results for Tags - <span style=\"background-color:#e84c3d;padding:4px;color: white;font-size: 18px;\">#");
            EndContext();
            BeginContext(2250, 26, false);
#line 39 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                                                                                                            Write(Model.Tag.Replace("-"," "));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 16, true);
            WriteLiteral(" </span> </h1>\r\n");
            EndContext();
#line 40 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2352, 147, true);
            WriteLiteral("                <h1 class=\"page-title\">Blog results for Author - <span style=\"background-color:#e84c3d;padding:4px;color: white;font-size: 18px;\">#");
            EndContext();
            BeginContext(2500, 12, false);
#line 43 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                                                                                                              Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(2512, 16, true);
            WriteLiteral(" </span> </h1>\r\n");
            EndContext();
#line 44 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                    }

#line default
#line hidden
            BeginContext(2551, 235, true);
            WriteLiteral("                <div class=\"separator-2\"></div>\r\n\r\n                <!-- page-title end -->\r\n                <!-- masonry grid start -->\r\n\r\n                <div>\r\n                    <div id=\"lvCandidatestbl\" class=\"masonry-grid row\">\r\n");
            EndContext();
#line 52 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                         foreach (var blog in Model.BlogsList)
                    {

#line default
#line hidden
            BeginContext(2873, 204, true);
            WriteLiteral("                        <div class=\"masonry-grid-item col-sm-6 col-md-4\" id=\"mydiv\">\r\n                            <!-- blogpost start -->\r\n                            <article class=\"clearfix blogpost\">\r\n");
            EndContext();
#line 57 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                 if (blog.VideoEmbed != null)
                                    {

#line default
#line hidden
            BeginContext(3179, 123, true);
            WriteLiteral("                                <div class=\"embed-responsive embed-responsive-16by9\">\r\n                                    ");
            EndContext();
            BeginContext(3303, 25, false);
#line 60 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                               Write(Html.Raw(blog.VideoEmbed));

#line default
#line hidden
            EndContext();
            BeginContext(3328, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 62 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3409, 180, true);
            WriteLiteral("                                <div class=\"blogpost-body\">\r\n                                    <div class=\"post-info\">\r\n                                        <span class=\"day\">");
            EndContext();
            BeginContext(3590, 24, false);
#line 65 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                     Write(blog.Date.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(3614, 69, true);
            WriteLiteral("</span>\r\n                                        <span class=\"month\">");
            EndContext();
            BeginContext(3684, 30, false);
#line 66 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                       Write(blog.Date.ToString("MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3714, 233, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"blogpost-content\">\r\n                                        <header>\r\n                                            <h2 class=\"title\">");
            EndContext();
            BeginContext(3947, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8685b87c2241508b1543477135c00217ff52d311539", async() => {
                BeginContext(4023, 10, false);
#line 70 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                                                                                                    Write(blog.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3956, "~/Blog/MyBlog?id=", 3956, 17, true);
#line 70 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
AddHtmlAttributeValue("", 3973, System.Web.HttpUtility.UrlEncode(blog.BlogUrl), 3973, 47, false);

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
            BeginContext(4037, 109, true);
            WriteLiteral("</h2>\r\n                                            <div class=\"submitted\"><i class=\"fa fa-user pr-5\"></i> by ");
            EndContext();
            BeginContext(4146, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8685b87c2241508b1543477135c00217ff52d313572", async() => {
                BeginContext(4203, 15, false);
#line 71 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                                                                                                                         Write(blog.AuthorName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4155, "~/Blog/Author/", 4155, 14, true);
#line 71 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
AddHtmlAttributeValue("", 4169, blog.AuthorId, 4169, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4183, "-", 4183, 1, true);
#line 71 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
AddHtmlAttributeValue("", 4184, blog.AuthorName, 4184, 16, false);

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
            BeginContext(4222, 102, true);
            WriteLiteral("</div>\r\n                                        </header>\r\n                                        <p>");
            EndContext();
            BeginContext(4325, 31, false);
#line 73 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                      Write(Html.Raw(blog.BlogIntroduction));

#line default
#line hidden
            EndContext();
            BeginContext(4356, 340, true);
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <footer class=""clearfix"">
                                    <ul class=""links pull-left"">

                                        <li>
                                            <i class=""fa fa-tags pr-5""></i>
");
            EndContext();
#line 81 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                             if (blog.Tags != null)
                                                {
                                                    foreach (var str in blog.Tags.Split(',').ToList())
                                                    {
                                                        if (!string.IsNullOrWhiteSpace(str))
                                                        {

#line default
#line hidden
            BeginContext(5128, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(5172, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8685b87c2241508b1543477135c00217ff52d317167", async() => {
                BeginContext(5234, 21, false);
#line 87 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                                                                    Write(str.Replace("-", " "));

#line default
#line hidden
                EndContext();
                BeginContext(5255, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(5258, 101, false);
#line 87 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                                                                                            Write(blog.Tags.Split(',').ToList().IndexOf(str).Equals(blog.Tags.Split(',').ToList().Count - 1) ? "" : ",");

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5181, "~/blog/tags/", 5181, 12, true);
#line 87 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
AddHtmlAttributeValue("", 5193, System.Web.HttpUtility.UrlEncode(str), 5193, 38, false);

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
            BeginContext(5364, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 88 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                                                        }
                                                    }
                                                }

#line default
#line hidden
            BeginContext(5531, 126, true);
            WriteLiteral("                                        </li>\r\n                                    </ul>\r\n                                    ");
            EndContext();
            BeginContext(5657, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8685b87c2241508b1543477135c00217ff52d320057", async() => {
                BeginContext(5722, 22, true);
                WriteLiteral("<span>Read more</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5690, "~/Blog/MyBlog?id=", 5690, 17, true);
#line 93 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
AddHtmlAttributeValue("", 5707, blog.BlogUrl, 5707, 13, false);

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
            BeginContext(5748, 168, true);
            WriteLiteral("\r\n                                </footer>\r\n                            </article>\r\n                            <!-- blogpost end -->\r\n                        </div>\r\n");
            EndContext();
#line 98 "E:\BlogCloud\code2night\Views\Blog\Tags.cshtml"
                    }

#line default
#line hidden
            BeginContext(5939, 282, true);
            WriteLiteral(@"

                    </div>
                    <!-- masonry grid end -->
                </div>
                <div style=""margin:auto auto"" id=""pagination""></div>
            </div>
            <!-- main end -->
            

        </div>
    </div>
</section>

");
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
