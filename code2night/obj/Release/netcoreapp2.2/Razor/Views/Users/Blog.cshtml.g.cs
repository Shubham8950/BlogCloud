#pragma checksum "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2994ae92b52b95f959ee0e81f2ce19228362b0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Blog), @"mvc.1.0.view", @"/Views/Users/Blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Blog.cshtml", typeof(AspNetCore.Views_Users_Blog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2994ae92b52b95f959ee0e81f2ce19228362b0d5", @"/Views/Users/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/blog-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/blog-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("popup-img overlay"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("image title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/blog-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/blog-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/blog-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/blog-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Blog.cshtml"
  
    ViewBag.Title = "Blog";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(85, 1810, true);
            WriteLiteral(@"<style>
    .btn-default {
    background-color: white !important;
    color: black !important;
    border-color: black !important;
}
    .btn-default:hover, .btn-default:focus, .btn-default:active, .btn-default.active, .open .dropdown-toggle.btn-default {
    color: #0066ff !important;
    background-color: #cd3c2e;
    border-color: #cd3c2e;
}
 .note-toolbar {
    position: static !important;
    z-index: 500;
}
      .btn-default:hover {
    background-color: white !important;
    color: black !important;
    border-color: black !important;
}
    .panel-heading a {
    font-weight: 400;
    padding: 12px 35px 12px 15px;
    display: inline-block;
    width: 100%;
    background-color: transparent;
    color: #ffffff;
    position: relative;
    text-decoration: none;
}
    .btn.btn-sm {
    padding: 8px;
    font-size: 12px;
    min-width: 55px;
}
    .btn
    {
       padding: 4px 2px !important;
    }
</style>
<section class=""main-container"" ng-app=""myapp"" ng-init=");
            WriteLiteral(@"""title=''"" ng-controller=""myctrlr"">

    <div class=""container"">
        <div class=""row"">

            <!-- main start -->
            <!-- ================ -->
            <div class=""main col-md-6"">

                <!-- page-title start -->
                <!-- ================ -->
                <h1 class=""page-title"" ng-if=""title!=''"" >{{title}}</h1>
                <h1 class=""page-title"" ng-if=""title==''"">Blogpost Title</h1>
                <!-- page-title end -->
                <!-- blogpost start -->
                <article class=""clearfix blogpost full"">
                    <div class=""blogpost-body"">
                        <div class=""side"">
                            <div class=""post-info"">
                                <span class=""day"">");
            EndContext();
            BeginContext(1896, 16, false);
#line 65 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Blog.cshtml"
                                             Write(DateTime.Now.Day);

#line default
#line hidden
            EndContext();
            BeginContext(1912, 61, true);
            WriteLiteral("</span>\r\n                                <span class=\"month\">");
            EndContext();
            BeginContext(1974, 29, false);
#line 66 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Blog.cshtml"
                                               Write(DateTime.Now.ToString("MMMM"));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2005, 17, false);
#line 66 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Blog.cshtml"
                                                                              Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2022, 629, true);
            WriteLiteral(@"</span>
                            </div>
                            <div id=""affix""><span class=""share"">Share This</span><div id=""share""></div></div>
                        </div>
                        <div class=""blogpost-content"">
                            <header>
                                <div class=""submitted""><i class=""fa fa-user pr-5""></i> by <a href=""#"">John Doe</a></div>
                            </header>
                            <div class=""owl-carousel content-slider-with-controls"">
                                <div class=""overlay-container"">
                                    ");
            EndContext();
            BeginContext(2651, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2994ae92b52b95f959ee0e81f2ce19228362b0d512463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2697, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2735, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2994ae92b52b95f959ee0e81f2ce19228362b0d513756", async() => {
                BeginContext(2819, 33, true);
                WriteLiteral("<i class=\"fa fa-search-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2856, 143, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"overlay-container\">\r\n                                    ");
            EndContext();
            BeginContext(2999, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2994ae92b52b95f959ee0e81f2ce19228362b0d515394", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3045, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3083, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2994ae92b52b95f959ee0e81f2ce19228362b0d516687", async() => {
                BeginContext(3167, 33, true);
                WriteLiteral("<i class=\"fa fa-search-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3204, 143, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"overlay-container\">\r\n                                    ");
            EndContext();
            BeginContext(3347, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2994ae92b52b95f959ee0e81f2ce19228362b0d518325", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3393, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3431, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2994ae92b52b95f959ee0e81f2ce19228362b0d519618", async() => {
                BeginContext(3515, 33, true);
                WriteLiteral("<i class=\"fa fa-search-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3552, 4376, true);
            WriteLiteral(@"
                                </div>
                            </div>
                          
                            <div ng-if=""!blogbody"" >
                                <p>
                                    Amet culpa, accusamus. Temporibus animi, consequatur cumque natus, esse consequuntur voluptatibus deleniti necessitatibus autem architecto quaerat tenetur nobis, ea maxime saepe rem doloribus placeat aliquid quod, id fuga ratione error harum ex! Facere vero veniam ducimus nulla sed possimus nobis nisi maiores quibusdam, nam odit quos dolores laborum pariatur distinctio in ex culpa impedit. Corrupti sequi perferendis atque nam debitis ea sunt, vel mollitia voluptas tempora eaque
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                                </p>
                                <p>Inventore, distinctio esse impedit deleniti, magnam minus culpa quia repellendus eligendi nam, omnis qui odio dolorem autem molestias eveni");
            WriteLiteral(@"et tempora rem odit possimus! At ea quidem, ipsa ducimus harum quod neque expedita perferendis, quis odio officiis dicta facere qui architecto! Neque, odio quidem a cum perferendis doloribus iure aut ducimus, eveniet commodi unde consequatur iusto error excepturi perspiciatis cupiditate voluptates ad, minus, magnam voluptatem tempora quae at temporibus incidunt. est reprehenderit, voluptates culpa, numquam minima.</p>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ex, eligendi cum officiis sint eveniet omnis eius quo. Et iusto eos dolor ratione nesciunt praesentium eveniet distinctio repellat. Quas, soluta, ipsam.</p>
                                <blockquote>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                                </blockquote>
                                <p>Lorem ipsum dolor sit amet, ");
            WriteLiteral(@"consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse illum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. </p>
                                <ul class=""list-icons"">
                                    <li><i class=""icon-check""></i> Eveniet distinctio repellat</li>
                                    <li><i class=""icon-check""></i> Sdipisicing elit</li>
                                    <li><i class=""icon-check""></i> Sint eveniet omnis eius quo</li>
                                    <li><i class=""icon-check""></i> Dolor ratione nesciunt</li>
                                </ul>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i");
            WriteLiteral(@"ncididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse.</p>
                            </div>
                            <div ng-if=""blogbody!=''""  >
                                <p ng-bind-html=""trustAsHtml(blogbody)"" id=""blog""></p>
                            </div>
                    </div>
                    <footer class=""clearfix"">
                        <ul class=""links pull-left"">
                            <li><i class=""fa fa-comment-o pr-5""></i> <a href=""#"">22 comments</a> |</li>
                            <li><i class=""fa fa-tags pr-5""></i> <a href=""#"">tag 1</a>, <a href=""#"">tag 2</a>, <a href=""#"">long tag 3</a> </li>
                        </ul>
                    </footer>
                        </div>
                </article>
                <!-- blogpost end -->
                <!-- comments start -->
     ");
            WriteLiteral(@"           <div class=""comments"">
                    <h2 class=""title"">There are 3 comments</h2>

                    <!-- comment start -->
                    <div class=""comment clearfix"">
                        <div class=""comment-avatar"">
                            ");
            EndContext();
            BeginContext(7928, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2994ae92b52b95f959ee0e81f2ce19228362b0d525653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7980, 3264, true);
            WriteLiteral(@"
                        </div>
                        <div class=""comment-content"">
                            <h3>Comment title</h3>
                            <div class=""comment-meta"">By <a href=""#"">admin</a> | Today, 12:31</div>
                            <div class=""comment-body clearfix"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo </p>
                                <a href=""blog-post.html"" class=""btn btn-gray more pull-right""><i class=""fa fa-reply""></i> Reply</a>
                            </div>
                        </div>

                        <!-- comment start -->
                        <div class=""comment clearfix"">
                            <div class=""comment-avatar"">
                                <img src=""images/avatar.jpg"" alt=""avatar"">
             ");
            WriteLiteral(@"               </div>
                            <div class=""comment-content clearfix"">
                                <h3>Comment title</h3>
                                <div class=""comment-meta"">By <a href=""#"">admin</a> | Today, 12:31</div>
                                <div class=""comment-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo </p>
                                    <a href=""blog-post.html"" class=""btn btn-gray more pull-right""><i class=""fa fa-reply""></i> Reply</a>
                                </div>
                            </div>
                        </div>
                        <!-- comment end -->

                    </div>
                    <!-- comment end -->
                    <!-- comment start -->
                    <div class=""commen");
            WriteLiteral(@"t clearfix"">
                        <div class=""comment-avatar"">
                            <img src=""images/avatar.jpg"" alt=""avatar"">
                        </div>
                        <div class=""comment-content clearfix"">
                            <h3>Comment title</h3>
                            <div class=""comment-meta"">By <a href=""#"">admin</a> | Today, 12:31</div>
                            <div class=""comment-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo </p>
                                <a href=""blog-post.html"" class=""btn btn-gray more pull-right""><i class=""fa fa-reply""></i> Reply</a>
                            </div>
                        </div>
                    </div>
                    <!-- comment end -->

                </div>
                <!-");
            WriteLiteral("- comments end -->\r\n                <!-- comments form start -->\r\n                <div class=\"comments-form\">\r\n                    <h2 class=\"title\">Add your comment</h2>\r\n                    ");
            EndContext();
            BeginContext(11244, 1250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2994ae92b52b95f959ee0e81f2ce19228362b0d530341", async() => {
                BeginContext(11280, 1207, true);
                WriteLiteral(@"
                        <div class=""form-group has-feedback"">
                            <label for=""name4"">Name</label>
                            <input type=""text"" class=""form-control"" id=""name4"" placeholder="""" name=""name4"" required>
                            <i class=""fa fa-user form-control-feedback""></i>
                        </div>
                        <div class=""form-group has-feedback"">
                            <label for=""subject4"">Subject</label>
                            <input type=""text"" class=""form-control"" id=""subject4"" placeholder="""" name=""subject4"" required>
                            <i class=""fa fa-pencil form-control-feedback""></i>
                        </div>
                        <div class=""form-group has-feedback"">
                            <label for=""message4"">Message</label>
                            <textarea class=""form-control"" rows=""8"" id=""message4"" placeholder="""" name=""message4"" required></textarea>
                            <i class=""f");
                WriteLiteral("a fa-envelope-o form-control-feedback\"></i>\r\n                        </div>\r\n                        <input type=\"submit\" value=\"Submit\" class=\"btn btn-default\">\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12494, 1618, true);
            WriteLiteral(@"
                </div>
                <!-- comments form end -->

            </div>
            <!-- main end -->
            <!-- sidebar start -->
            <aside class=""col-md-5 col-md-offset-1"">
                <div class=""sidebar"">
                    <div class=""block clearfix"">
                        <h3 class=""title"">Write New Blog</h3>
                        <div class=""separator""></div>
                        <nav>
                            <ul class=""nav nav-pills nav-stacked"">
                                <li>
                                    <label for=""title"">Title</label>
                                <input type=""text"" class=""form-control"" id=""title"" ng-model=""title""/>
                                <label for=""blogbody"">Article</label><div class=""example"" >
    <summernote config=""options"" ng-model=""blogbody""></summernote>

</div></li>
                                <li><label for=""tokenfield"">Categories</label><input type=""text"" ng-change=""showblog($");
            WriteLiteral(@"event)"" class=""form-control"" id=""tokenfield"" ng-model=""tags""  value=""red,green,blue"" placeholder=""Type something and hit enter"" /></li>
                              
                                <li><label for=""title"">Video Embed Link</label>
<input type=""text"" class=""form-control"" id=""videoembed"" ng-model=""VideoEmbed"" /></li>
                                 <li>
                                <button id=""submit"" value=""Submit Blog"" class=""btn btn-success"">Submit Blog</button></li>
                            </ul>
                        </nav>
                    </div>
");
            EndContext();
            BeginContext(22488, 1913, true);
            WriteLiteral(@"                  </div>
            </aside>
         

        </div>
    </div>
</section>



<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"" ></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js""></script>
<script src=""https://code.jquery.com/jquery-migrate-3.0.0.min.js""></script>

<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.7/angular-route.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.7/angular-resource.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/angular-ui-router/1.0.22/angular-ui-router.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/angular-summernote/0.8.1/angular-summernote.js""></script>


<script>
   
    $('#tokenfield').tokenfield({
        autocomplete: {

            source: ['red', 'blue', 'green', 'yellow', 'violet', 'brown', 'purple', 'black', 'white'],
            delay: 100
        }");
            WriteLiteral(@",
        showAutocompleteOnFocus: true
    })
    //$('#blogbody').summernote();
  
    //var app = angular.module('myapp', [])
    //app.controller('myctrlr', function ($scope, $http, $window) {
       
      
      
    //    $scope.showblog=
    //    function(event)
    //    {
    //        debugger;
    //        $scope.text = event.html();
    //    };





       
    //});

</script>
<script>
    //$('#mydiv').summernote();
  angular.module('myapp', ['ui.router', 'summernote'])
  .controller('myctrlr', function ($scope,$sce) {
    $scope.options = {
      height: 150,
     
    };
    $scope.AddBlog = function () {
        debugger;
        var Data = JSON.stringify({ Title: $scope.Title, Tags: $scope.Tags, BlogBody: $scope.finalbody, VideoEmbed: $scope.VideoEmbed });
        $http({
            method: ""POST"",
            url: '");
            EndContext();
            BeginContext(24402, 29, false);
#line 431 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Blog.cshtml"
             Write(Url.Action("AddBlog", "Blog"));

#line default
#line hidden
            EndContext();
            BeginContext(24431, 749, true);
            WriteLiteral(@"',
            dataType: 'json',
            data: Data,
            headers: { ""Content-Type"": ""application/json"" }
        }).then(function (response) {
            if (response.data == 0)
                $scope.SuccessFulRegistration();
            else {
                Swal.fire({
                    position: 'top-center',
                    type: 'info',
                    title: ""Email aready being used"",
                    showConfirmButton: false,
                    timer: 3000
                });
            }

        }, function (error) {
            $window.alert(error);
        });
    }
    $scope.trustAsHtml = function (html) {
        return $sce.trustAsHtml(html);
    }
   
  });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591