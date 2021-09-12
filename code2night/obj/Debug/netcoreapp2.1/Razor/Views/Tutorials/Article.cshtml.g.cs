#pragma checksum "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2141571d750f2818f5b31cd6ee880fb4f5bf42ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tutorials_Article), @"mvc.1.0.view", @"/Views/Tutorials/Article.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tutorials/Article.cshtml", typeof(AspNetCore.Views_Tutorials_Article))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2141571d750f2818f5b31cd6ee880fb4f5bf42ea", @"/Views/Tutorials/Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Tutorials_Article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.Models.AritclesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/plugins/jquery.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
  
    ViewData["Title"] = "Article";


#line default
#line hidden
            BeginContext(83, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2141571d750f2818f5b31cd6ee880fb4f5bf42ea4214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 5 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(178, 1293, true);
            WriteLiteral(@"
    <style>
        .articleactive {
            background-color: #efefef !important;
        }

        .code-panel {
            margin:10px 0px;
            background-color: #fff;
            border: 1px solid #2590e3;
            border-radius: 0;
           
        }

        pre {
            background-color: white !important;
            border: 0px;
        }
        .footer h1, .footer h2, .footer h3, .footer h4, .footer h5, .footer h6 {
            color: #999 !important;
        }
        .articlefont {
            font-size: 16px !important;
            line-height: 31px;
            /* text-align: justify; */
            font-family: Verdana,sans-serif,Geneva !important;
            color: #000 !important;
            background: transparent;
        }

        h1, h2, h3 {
            font-family: ""Segoe UI"",Verdana,sans-serif !important;
            font-weight: 400 !important;
            line-height: 1.2 !important;
            color: #181717 !important;");
            WriteLiteral(@"
        }
    </style>
    <div class=""page-intro"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <ol class=""breadcrumb"">
                        <li><i class=""fa fa-home pr-10""></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1471, "\"", 1506, 1);
#line 47 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
WriteAttributeValue("", 1478, Url.Action("Index","Users"), 1478, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1507, 46, true);
            WriteLiteral(">Home</a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1553, "\"", 1592, 1);
#line 48 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
WriteAttributeValue("", 1560, Url.Action("index","Tutorials"), 1560, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1593, 64, true);
            WriteLiteral(">Tutorials</a></li>\r\n                        <li class=\"active\">");
            EndContext();
            BeginContext(1658, 13, false);
#line 49 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                                      Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1671, 277, true);
            WriteLiteral(@"</li>
                    </ol>
                </div>
            </div>
        </div>
    </div>
    <section class=""main-container"" style=""margin-top: 0px;"">

        <div class=""container"">
            <div class=""row"">

                <!-- sidebar start -->
");
            EndContext();
#line 61 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                 if (Model.GetArticles.Count() > 0)
                {

#line default
#line hidden
            BeginContext(2020, 203, true);
            WriteLiteral("                    <aside class=\"col-md-3\">\r\n                        <div class=\"sidebar\">\r\n                            <div class=\"block clearfix\">\r\n\r\n                                <h3 class=\"title\">");
            EndContext();
            BeginContext(2224, 46, false);
#line 67 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                                             Write(Model.GetArticles.FirstOrDefault()?.Topictitle);

#line default
#line hidden
            EndContext();
            BeginContext(2270, 185, true);
            WriteLiteral("</h3>\r\n                                <div class=\"separator\"></div>\r\n                                <nav>\r\n                                    <ul class=\"nav nav-pills nav-stacked\">\r\n");
            EndContext();
#line 71 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                                         foreach (var item in Model.GetArticles)
                                        {

#line default
#line hidden
            BeginContext(2580, 50, true);
            WriteLiteral("                                            <li><a");
            EndContext();
            BeginWriteAttribute("class", " class=\'", 2630, "\'", 2717, 2);
            WriteAttributeValue("", 2638, "article", 2638, 7, true);
#line 73 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
WriteAttributeValue(" ", 2645, Model.ArticleDetails?.articleurl==item.articleurl?"articleactive":"", 2646, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2718, "\"", 2762, 3);
            WriteAttributeValue("", 2728, "fetchArticle(", 2728, 13, true);
#line 73 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
WriteAttributeValue("", 2741, item.articleid, 2741, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2756, ",this)", 2756, 6, true);
            EndWriteAttribute();
            BeginContext(2763, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2765, 17, false);
#line 73 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                                                                                                                                                                                   Write(item.articletitle);

#line default
#line hidden
            EndContext();
            BeginContext(2782, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 74 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2836, 181, true);
            WriteLiteral("                                    </ul>\r\n                                </nav>\r\n                            </div>\r\n                        </div>\r\n                    </aside>\r\n");
            EndContext();
#line 80 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3077, 82, true);
            WriteLiteral("                    <h1 style=\"text-align:center\">Sorry ! No Articles Found</h1>\r\n");
            EndContext();
#line 84 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                }

#line default
#line hidden
            BeginContext(3178, 202, true);
            WriteLiteral("                <!-- sidebar end -->\r\n                <!-- main start -->\r\n                <!-- ================ -->\r\n                <div class=\"main col-md-8 col-md-offset-1\" id=\"Articlespartialid\">\r\n");
            EndContext();
#line 89 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                     if (Model.ArticleDetails.articleid != 0)
                    {
                        Html.RenderPartial("_Article", Model.ArticleDetails);
                    }

#line default
#line hidden
            BeginContext(3568, 168, true);
            WriteLiteral("                </div>\r\n                <!-- main end -->\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <script>\r\n        $(document).ready(function () {\r\n");
            EndContext();
#line 101 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
               if (Model.ArticleDetails.articleid == 0)
                  {

#line default
#line hidden
            BeginContext(3814, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3828, 45, true);
            WriteLiteral(" $(\'.article\').first().click();\r\n            ");
            EndContext();
            BeginContext(3875, 49, true);
            WriteLiteral(" $(\'.article:first\').addClass(\'articleactive\');\r\n");
            EndContext();
#line 105 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                  }

#line default
#line hidden
            BeginContext(3945, 539, true);
            WriteLiteral(@"        })
        function LoadPartialViewPromise(url, elem, postData) {
          
            var promise = $.post(url, postData, function (result, status) {

                $(""#"" + elem).html('');
                $(""#"" + elem).html(result);
              

            });
            return promise;
        }
        var fetchArticle = function (id, elem) {
            $('.articleactive').removeClass('articleactive');
            $(elem).addClass('articleactive');
            var promise = LoadPartialViewPromise('");
            EndContext();
            BeginContext(4485, 40, false);
#line 121 "E:\BlogCloud\code2night\Views\Tutorials\Article.cshtml"
                                             Write(Url.Action("ArticleDetail", "Tutorials"));

#line default
#line hidden
            EndContext();
            BeginContext(4525, 608, true);
            WriteLiteral(@"', ""Articlespartialid"", { id: id });
            promise.done(function (data) {
                $('#Articlespartialid').html(data);
                $('pre').each(function (index, elem) {
                    $(elem).wrap(""<div class='code-panel'></div>"")
                });
                $('#Articlespartialid').find('p,div,li,span').each(function (index, elem) {
                    $(elem).addClass(""articlefont"")
                });
            })
        }
        function wrapNode(node) {
            $(node).replaceWith(""<p>"" + node.textContent + ""</p>"");
        }


    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.Models.AritclesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
