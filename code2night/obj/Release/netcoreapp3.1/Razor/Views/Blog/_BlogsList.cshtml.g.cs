#pragma checksum "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2e9bafffc7492776eb3e8532aab15f6ff56e8fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__BlogsList), @"mvc.1.0.view", @"/Views/Blog/_BlogsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/_BlogsList.cshtml", typeof(AspNetCore.Views_Blog__BlogsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2e9bafffc7492776eb3e8532aab15f6ff56e8fa", @"/Views/Blog/_BlogsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog__BlogsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.MyBlogs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/plugins/isotope/isotope.pkgd.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("itemprop", new global::Microsoft.AspNetCore.Html.HtmlString("author"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("itemprop", new global::Microsoft.AspNetCore.Html.HtmlString("keywords"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-right link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("itemprop", new global::Microsoft.AspNetCore.Html.HtmlString("url"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
 foreach (var item in Model.BlogsList)
{

#line default
#line hidden
            BeginContext(83, 53, true);
            WriteLiteral("    <script type=\"application/ld+json\">\r\n    {\r\n    \"");
            EndContext();
            BeginContext(137, 39, true);
            WriteLiteral("@context\" : \"http://schema.org\",\r\n    \"");
            EndContext();
            BeginContext(177, 35, true);
            WriteLiteral("@type\" : \"Article\",\r\n    \"name\" : \"");
            EndContext();
            BeginContext(213, 10, false);
#line 9 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
         Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(223, 22, true);
            WriteLiteral("\",\r\n    \"headline\" : \"");
            EndContext();
            BeginContext(246, 10, false);
#line 10 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(256, 69, true);
            WriteLiteral("\",\r\n    \"url\" : \"https://www.blogcloud.code2night.com/Blog/MyBlog?id=");
            EndContext();
            BeginContext(327, 46, false);
#line 11 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                                             Write(System.Web.HttpUtility.UrlEncode(item.BlogUrl));

#line default
#line hidden
            EndContext();
            BeginContext(374, 27, true);
            WriteLiteral("\",\r\n    \"author\" : {\r\n    \"");
            EndContext();
            BeginContext(402, 34, true);
            WriteLiteral("@type\" : \"Person\",\r\n    \"name\" : \"");
            EndContext();
            BeginContext(437, 15, false);
#line 14 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
         Write(item.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(452, 34, true);
            WriteLiteral("\"\r\n    },\r\n    \"datePublished\" : \"");
            EndContext();
            BeginContext(487, 32, false);
#line 16 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                  Write(item.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(519, 28, true);
            WriteLiteral("\",\r\n    \"articleSection\" : \"");
            EndContext();
            BeginContext(548, 21, false);
#line 17 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                   Write(item.BlogIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(569, 25, true);
            WriteLiteral("\",\r\n    \"articleBody\" : \"");
            EndContext();
            BeginContext(595, 13, false);
#line 18 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                Write(item.BlogBody);

#line default
#line hidden
            EndContext();
            BeginContext(608, 30, true);
            WriteLiteral("\",\r\n    \"publisher\" : {\r\n    \"");
            EndContext();
            BeginContext(639, 82, true);
            WriteLiteral("@type\" : \"Organization\",\r\n    \"name\" : \"BlogCloud\"\r\n    }\r\n     }\r\n    </script>\r\n");
            EndContext();
#line 25 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
}

#line default
#line hidden
            BeginContext(724, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(726, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2e9bafffc7492776eb3e8532aab15f6ff56e8fa9286", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 27 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(812, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
 foreach (var blog in Model.BlogsList.Where(x => x.IsApproved))
{

#line default
#line hidden
            BeginContext(882, 188, true);
            WriteLiteral("    <div class=\"masonry-grid-item col-sm-6 col-md-4\" id=\"mydiv\">\r\n        <!-- blogpost start -->\r\n        <article class=\"clearfix blogpost\" itemscope itemtype=\"http://schema.org/Blog\">\r\n");
            EndContext();
            BeginContext(1314, 248, true);
            WriteLiteral("            <div class=\"blogpost-body\" style=\'max-height: 410px;\r\n    overflow: hidden;\r\n    text-overflow: ellipsis;\r\n    max-width: 351px;\'>\r\n                <div class=\"post-info\" itemprop=\"datePublished\">\r\n                    <span class=\"day\">");
            EndContext();
            BeginContext(1563, 24, false);
#line 44 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                 Write(blog.Date.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 49, true);
            WriteLiteral("</span>\r\n                    <span class=\"month\">");
            EndContext();
            BeginContext(1637, 30, false);
#line 45 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                   Write(blog.Date.ToString("MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 173, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"blogpost-content\">\r\n                    <header>\r\n                        <h2 itemprop=\"headline\" class=\"title\">");
            EndContext();
            BeginContext(1840, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2e9bafffc7492776eb3e8532aab15f6ff56e8fa12761", async() => {
                BeginContext(1916, 10, false);
#line 49 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                                                                                                                    Write(blog.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1849, "~/Blog/MyBlog?id=", 1849, 17, true);
#line 49 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
AddHtmlAttributeValue("", 1866, System.Web.HttpUtility.UrlEncode(blog.BlogUrl), 1866, 47, false);

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
            BeginContext(1930, 119, true);
            WriteLiteral("</h2>\r\n                        <div class=\"submitted\">\r\n                            <i class=\"fa fa-user pr-5\"></i> by ");
            EndContext();
            BeginContext(2049, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2e9bafffc7492776eb3e8532aab15f6ff56e8fa14844", async() => {
                BeginContext(2124, 15, false);
#line 51 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                                                                                                                    Write(blog.AuthorName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2076, "~/Blog/Author/", 2076, 14, true);
#line 51 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
AddHtmlAttributeValue("", 2090, blog.AuthorId, 2090, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2104, "-", 2104, 1, true);
#line 51 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
AddHtmlAttributeValue("", 2105, blog.AuthorName, 2105, 16, false);

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
            BeginContext(2143, 82, true);
            WriteLiteral("<a style=\"\r\n    color: black;\r\n    margin-left: 16px;\r\n\"><i class=\"fa fa-eye\"></i>");
            EndContext();
            BeginContext(2226, 14, false);
#line 54 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                      Write(blog.TotalView);

#line default
#line hidden
            EndContext();
            BeginContext(2240, 51, true);
            WriteLiteral("</a>\r\n</div>\r\n</header>\r\n<p itemprop=\"articleBody\">");
            EndContext();
            BeginContext(2292, 21, false);
#line 57 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                     Write(blog.BlogIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(2313, 144, true);
            WriteLiteral("</p>\r\n</div>\r\n</div>\r\n<footer class=\"clearfix\">\r\n    <ul class=\"links pull-left\">\r\n\r\n        <li>\r\n            <i class=\"fa fa-tags pr-5\"></i>\r\n");
            EndContext();
#line 65 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
             if (blog.Tags != null)
            {
                var list = blog.Tags.Split(',').ToList().Take(2).ToList();
                foreach (var str in list)
                {
                    if (!string.IsNullOrWhiteSpace(str))
                    {

#line default
#line hidden
            BeginContext(2728, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2752, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2e9bafffc7492776eb3e8532aab15f6ff56e8fa18578", async() => {
                BeginContext(2834, 21, false);
#line 72 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                                                                                    Write(str.Replace("-", " "));

#line default
#line hidden
                EndContext();
                BeginContext(2855, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2858, 51, false);
#line 72 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                                                                                                            Write(list.IndexOf(str).Equals(list.Count - 1) ? "" : ",");

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2781, "~/blog/tags/", 2781, 12, true);
#line 72 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
AddHtmlAttributeValue("", 2793, System.Web.HttpUtility.UrlEncode(str), 2793, 38, false);

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
            BeginContext(2914, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                    }
                }
            }

#line default
#line hidden
            BeginContext(2973, 34, true);
            WriteLiteral("\r\n\r\n        </li>\r\n    </ul>\r\n    ");
            EndContext();
            BeginContext(3007, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2e9bafffc7492776eb3e8532aab15f6ff56e8fa21380", async() => {
                BeginContext(3123, 22, true);
                WriteLiteral("<span>Read more</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3055, "~/blog/MyBlog?id=", 3055, 17, true);
#line 80 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
AddHtmlAttributeValue("", 3072, System.Web.HttpUtility.UrlEncode(blog.BlogUrl), 3072, 49, false);

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
            BeginContext(3149, 56, true);
            WriteLiteral("\r\n</footer>\r\n</article>\r\n<!-- blogpost end -->\r\n</div>\r\n");
            EndContext();
#line 85 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(3231, 120, true);
                WriteLiteral("\r\n    <script type=\'text/javascript\'>\r\n        $(document).ready(function () {\r\n             $(\'#hdnTotalRecords\').val(\'");
                EndContext();
                BeginContext(3353, 69, false);
#line 90 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\_BlogsList.cshtml"
                                    Write(Model.BlogsList.Any()?Model.BlogsList.FirstOrDefault().TotalRecords:0);

#line default
#line hidden
                EndContext();
                BeginContext(3423, 35, true);
                WriteLiteral("\');\r\n        });\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
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
