#pragma checksum "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2303827aa20494d8b6f75fa49737c286c452b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2303827aa20494d8b6f75fa49737c286c452b25", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Code2Night.DAL.Common.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
  
    ViewBag.Title = "Index | Code2night.com";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 428, true);
            WriteLiteral(@"<style>
    #video.iframe {
        width: 100% !important;
    }
</style>
<section class=""main-container"" style=""padding: 0px 0px"">
    <div class=""container"">
        <div class=""row"">
            <div class=""main col-md-8"">
                <!-- page-title start -->
                <!-- ================ -->
                <h3 class=""page-title"">Latest Blog</h3>
                <div class=""separator-2""></div>
");
            EndContext();
#line 19 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                 foreach (var item in Model.Where(x => x.IsApproved).OrderByDescending(x => x.Date))
                {

#line default
#line hidden
            BeginContext(698, 332, true);
            WriteLiteral(@"                    <article class=""clearfix blogpost object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""200"">
                        <div class=""blogpost-body"">
                            <div class=""post-info"">
                                <span class=""day"">");
            EndContext();
            BeginContext(1031, 24, false);
#line 24 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                             Write(item.Date.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 61, true);
            WriteLiteral("</span>\r\n                                <span class=\"month\">");
            EndContext();
            BeginContext(1117, 30, false);
#line 25 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                               Write(item.Date.ToString("MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 238, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"blogpost-content\">\r\n                                <header>\r\n                                    <h2 class=\"title\" style=\"font-weight: 400 !important;\">");
            EndContext();
            BeginContext(1385, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2303827aa20494d8b6f75fa49737c286c452b256984", async() => {
                BeginContext(1477, 10, false);
#line 29 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                                                                                                                                                                 Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1410, "~/Blog/MyBlog?id=", 1410, 17, true);
#line 29 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 1427, System.Web.HttpUtility.UrlEncode(item.BlogUrl), 1427, 47, false);

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
            BeginContext(1491, 180, true);
            WriteLiteral("</h2>\r\n                                    <div class=\"submitted\" style=\"font-size:14px !important;\">\r\n                                        <i class=\"fa fa-user pr-5\"></i> by <a");
            EndContext();
            BeginWriteAttribute("href", "  href=\"", 1671, "\"", 1727, 4);
            WriteAttributeValue("", 1679, "/Blog/Author/", 1679, 13, true);
#line 31 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
WriteAttributeValue("", 1692, item.AuthorId, 1692, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1708, "-", 1708, 1, true);
#line 31 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
WriteAttributeValue("", 1709, item.AuthorName, 1709, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1728, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1730, 15, false);
#line 31 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                                                                                                                  Write(item.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 72, true);
            WriteLiteral("</a><a style=\"color: black;margin-left: 16px;\"><i class=\"fa fa-eye\"></i>");
            EndContext();
            BeginContext(1818, 14, false);
#line 31 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                                                                                                                                                                                                          Write(item.TotalView);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 32 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                         if (!string.IsNullOrEmpty(item.VideoEmbed))
                                        {

#line default
#line hidden
            BeginContext(1967, 46, true);
            WriteLiteral("                                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2013, "\"", 2052, 3);
            WriteAttributeValue("", 2023, "ShowVideo(\'", 2023, 11, true);
#line 34 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
WriteAttributeValue("", 2034, item.VideoEmbed, 2034, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2050, "\')", 2050, 2, true);
            EndWriteAttribute();
            BeginContext(2053, 303, true);
            WriteLiteral(@" data-toggle=""modal"" data-target=""#myModal"" style=""margin-left:5px;font-size:14px;color:black;"" href=""http://www.youtube.com/"">

                                                <i class=""fa fa-youtube-play"" style=""color: #e84c3d
""></i>  Watch Video
                                            </a>
");
            EndContext();
#line 39 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                         }

#line default
#line hidden
            BeginContext(2400, 158, true);
            WriteLiteral("                                    </div>\r\n\r\n                                </header>\r\n                                <p style=\"font-size:13px !important\">");
            EndContext();
            BeginContext(2559, 21, false);
#line 43 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                                                Write(item.BlogIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(2580, 108, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </article>\r\n");
            EndContext();
#line 48 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2707, 565, true);
            WriteLiteral(@"            </div>

            <aside class=""col-md-4"">
                <div class=""sidebar"">

                    <div class=""block clearfix"">
                        <h3 class=""title"">Top Trending</h3>
                        <div class=""separator""></div>
                        <div class=""block clearfix"" style=""padding-bottom:0px !important "">
                            <script async src=""https://cse.google.com/cse.js?cx=54fa958b97e2934d7""></script>
                            <div class=""gcse-search""></div>

                        </div>
");
            EndContext();
#line 62 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                         foreach (var item in Model.Where(x => x.IsApproved).OrderByDescending(x => x.TotalView))
                        {

#line default
#line hidden
            BeginContext(3414, 157, true);
            WriteLiteral("                            <ul class=\"tweets\">\r\n                                <li>\r\n                                    <i class=\"fa fa-line-chart\"></i>\r\n");
            EndContext();
            BeginContext(3631, 53, true);
            WriteLiteral("                                    <p class=\"title\">");
            EndContext();
            BeginContext(3684, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2303827aa20494d8b6f75fa49737c286c452b2514593", async() => {
                BeginContext(3798, 10, false);
#line 68 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                                                                                                                                                 Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3731, "~/Blog/MyBlog?id=", 3731, 17, true);
#line 68 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 3748, System.Web.HttpUtility.UrlEncode(item.BlogUrl), 3748, 47, false);

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
            BeginContext(3812, 82, true);
            WriteLiteral("</p>\r\n\r\n                                </li>\r\n                            </ul>\r\n");
            EndContext();
#line 72 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3921, 244, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"block clearfix\">\r\n                        <h3 class=\"title\">Featured Post</h3>\r\n                        <div class=\"separator\"></div>\r\n                        <div class=\"image-box\">\r\n");
            EndContext();
#line 78 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(4254, 116, true);
            WriteLiteral("                                <div class=\"image-box-body\">\r\n                                    <h3 class=\"title\">");
            EndContext();
            BeginContext(4370, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2303827aa20494d8b6f75fa49737c286c452b2517740", async() => {
                BeginContext(4462, 10, false);
#line 81 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                                                                                                                                            Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4395, "~/Blog/MyBlog?id=", 4395, 17, true);
#line 81 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 4412, System.Web.HttpUtility.UrlEncode(item.BlogUrl), 4412, 47, false);

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
            BeginContext(4476, 88, true);
            WriteLiteral("</h3>\r\n                                    <p></p>\r\n                                    ");
            EndContext();
            BeginContext(4564, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2303827aa20494d8b6f75fa49737c286c452b2519871", async() => {
                BeginContext(4668, 22, true);
                WriteLiteral("<span>Read More</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4589, "~/Blog/MyBlog?id=", 4589, 17, true);
#line 83 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 4606, System.Web.HttpUtility.UrlEncode(item.BlogUrl), 4606, 47, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4694, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 85 "E:\blogCloudGit\BlogCloud\code2night\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4767, 146, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            BeginContext(5768, 5622, true);
            WriteLiteral(@"<section class=""main-container"" style=""padding: 0px 0px"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h1 class=""text-center title"">Core Features</h1>
                <div class=""separator""></div>
                <p class=""text-center""></p>
                <div class=""row grid-space-20"">
                    <div class=""col-sm-6"">
                        <div class=""box-style-3 right object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""0"">
                            <div class=""icon-container default-bg"">
                                <i class=""fa fa-code""></i>
                            </div>
                            <div class=""body"">
                                <h2>Code2night Tutorials</h2>
                                <p>Code2night Tutorials contains references to programming solutions</p>
                            </div>
                        </div");
            WriteLiteral(@">
                        <div class=""box-style-3 right object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""200"">
                            <div class=""icon-container default-bg"">
                                <i class=""fa fa-check""></i>
                            </div>
                            <div class=""body"">
                                <h2>Technologies We Provide's</h2>
                                <p>ASP .NET CORE ,JQUERY, ASP.NET MVC , SQL SERVER</p>
                            </div>
                        </div>
                        <div class=""box-style-3 right object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""400"">
                            <div class=""icon-container default-bg"">
                                <i class=""fa fa-book""></i>
                            </div>
                            <div class=""body"">
                  ");
            WriteLiteral(@"              <h2>Blog</h2>
                                <p>Welcome to the Blog section of Code2night...</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""box-style-3 object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""0"">
                            <div class=""icon-container default-bg"">
                                <i class=""fa fa-leaf""></i>
                            </div>
                            <div class=""body"">
                                <h2>Tutorials</h2>
                                <p>Learn C# ,SQL, Angularjs , Asp.net ...</p>
                            </div>
                        </div>
                        <div class=""box-style-3 object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""200"">
                    ");
            WriteLiteral(@"        <div class=""icon-container default-bg"">
                                <i class=""fa fa-lightbulb-o""></i>
                            </div>
                            <div class=""body"">
                                <h2>Forum</h2>
                                <p>C# Forum, C# Forums, Forums, ASP.NET Forum, VB.NET, WPF ...</p>
                            </div>
                        </div>
                        <div class=""box-style-3 object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""400"">
                            <div class=""icon-container default-bg"">
                                <i class=""fa fa-code""></i>
                            </div>
                            <div class=""body"">
                                <h2>Latest Technologies</h2>
                                <p>C# ,Asp.Net core</p>
                            </div>
                        </div>
                    </div>
          ");
            WriteLiteral(@"      </div>
            </div>
        </div>
    </div>
</section>
<section class=""main-container default-bg"">
    <div class=""main"">
        <div class=""container"">
            <div class=""call-to-action"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <blockquote class=""inline"">
                            <p class=""margin-clear"">Never study to be successful, study for self-efficiency. Don’t run behind success. Follow behind excellence, success will come all way behind you.</p>
                            <footer style=""color:white;font-size:20px;""><cite title=""Source Title"">3 Idiots </cite></footer>
                        </blockquote>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
      ");
            WriteLiteral(@"      <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">&times;</span><span class=""sr-only"">Close</span></button>
                <h4 class=""modal-title"" id=""myModalLabel"">Play Video Tutorial</h4>
            </div>
            <div class=""modal-body"" id=""video"">

            </div>

        </div>
    </div>
</div>
<script>
    var ShowVideo = function (data) {
        $('#video').html(data);
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Code2Night.DAL.Common.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
