#pragma checksum "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0ab9c82d44f07290b9f4dae2abea2e9e8e766bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Author), @"mvc.1.0.view", @"/Views/Blog/Author.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Author.cshtml", typeof(AspNetCore.Views_Blog_Author))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0ab9c82d44f07290b9f4dae2abea2e9e8e766bf", @"/Views/Blog/Author.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Author : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.MyBlogs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
  
    ViewBag.Title = (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author)+ " Blogs | Code2Night.com";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.MetaDescription = "Welcome To Code2night, check out latest programming blogs with detailed description to help you out";
    ViewBag.MetaKeywords = "Code2Night,Code,Programming,Tutorials," + (!string.IsNullOrEmpty(Model.Tag)?Model.Tag:Model.Author);
    ViewBag.Canonical = "https://www.code2night.com/Blog/"+ (!string.IsNullOrEmpty(Model.Tag) ? "Tags" : "Author") + "/"+ (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author);

    ViewBag.OpenGraphUrl = "https://www.code2night.com/Blog/" + (!string.IsNullOrEmpty(Model.Tag) ? "Tags" : "Author") + "/" + (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author);
    ViewBag.OpenGraphDescription = "Welcome To Code2night, check out latest programming blogs with detailed description to help you out";
    ViewBag.OpenGraphTitle = (!string.IsNullOrEmpty(Model.Tag) ? Model.Tag : Model.Author) + " Blogs | Code2Night.com";
    List<string> List = new List<string>();
    foreach (var item in Model.BlogsList.Where(x => x.Tags != null).Select(x => x.Tags.Split(',')).ToList())
    {

        foreach (var tag in item)
        {
            List.Add(tag.Trim());
        }

    }

#line default
#line hidden
            BeginContext(1371, 218, true);
            WriteLiteral("<div class=\"page-intro\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li><i class=\"fa fa-home pr-10\"></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1589, "\"", 1624, 1);
#line 28 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
WriteAttributeValue("", 1596, Url.Action("Index","Users"), 1596, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1625, 121, true);
            WriteLiteral(">Home</a></li>\r\n                    <li>Blogs    </li>\r\n                    <li class=\"active\">\r\n                        ");
            EndContext();
            BeginContext(1748, 49, false);
#line 31 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                    Write(!string.IsNullOrEmpty(Model.Tag)?"Tags":"Authors");

#line default
#line hidden
            EndContext();
            BeginContext(1798, 55, true);
            WriteLiteral("\r\n\r\n                    </li>\r\n                    <li>");
            EndContext();
            BeginContext(1854, 23, false);
#line 34 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                   Write(Model.AuthorDetail.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1877, 425, true);
            WriteLiteral(@"    </li>
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
            <div class=""main col-md-12"">

                <!-- page-title start -->
                <!-- ================ -->
                <h1 class=""page-title"">");
            EndContext();
            BeginContext(2303, 23, false);
#line 51 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                                  Write(Model.AuthorDetail.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2326, 357, true);
            WriteLiteral(@"</h1>
                <div class=""separator-2""></div>
                <div class=""space""></div>
                <!-- page-title end -->

                <div class=""row"">
                    <div class=""col-lg-8 col-sm-12"">
                        <div class=""box-style-1 gray-bg team-member"" style="" text-align: left;"">
                            ");
            EndContext();
            BeginContext(2684, 47, false);
#line 59 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                       Write(Html.Raw(Model.AuthorDetail.ProfileDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 172, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"block clearfix\">\r\n                            \r\n                            <div class=\"tags-cloud\">\r\n");
            EndContext();
#line 64 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                                 foreach (var str in Model.AuthorDetail.Skills.Split(","))
                                {

#line default
#line hidden
            BeginContext(3030, 156, true);
            WriteLiteral("                                <div class=\"tag\" itemprop=\"keywords\">\r\n                                    <a style=\"background-color: #e84c3d;color:white\">");
            EndContext();
            BeginContext(3187, 3, false);
#line 67 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                                                                                Write(str);

#line default
#line hidden
            EndContext();
            BeginContext(3190, 46, true);
            WriteLiteral("</a>\r\n                                </div>\r\n");
            EndContext();
#line 69 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                                }

#line default
#line hidden
            BeginContext(3271, 72, true);
            WriteLiteral("                            </div>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(4701, 402, true);
            WriteLiteral(@"                        </div>

                        <div class=""col-lg-3 col-md-12 col-sm-8 col-sm-offset-4 col-md-offset-0"">
                            <div class=""vertical-divider-left-lg side"">
                                <h2 class=""title"">Contact Me</h2>
                                <ul class=""list-icons"">
                                    <li><i class=""fa fa-phone pr-5""></i>");
            EndContext();
            BeginContext(5104, 28, false);
#line 102 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                                                                   Write(Model.AuthorDetail.ContactNo);

#line default
#line hidden
            EndContext();
            BeginContext(5132, 114, true);
            WriteLiteral("</li>\r\n                                    <li style=\"white-space: nowrap;\"><i class=\"fa fa-envelope pr-5\"></i><a>");
            EndContext();
            BeginContext(5247, 24, false);
#line 103 "E:\blogCloudGit\BlogCloud\code2night\Views\Blog\Author.cshtml"
                                                                                                      Write(Model.AuthorDetail.Email);

#line default
#line hidden
            EndContext();
            BeginContext(5271, 791, true);
            WriteLiteral(@"</a></li>
                                </ul>
                                <ul class=""social-links colored clearfix"">
                                    <li class=""twitter""><a target=""_blank"" href=""http://www.twitter.com/""><i class=""fa fa-twitter""></i></a></li>
                                    <li class=""skype""><a target=""_blank"" href=""http://www.skype.com/""><i class=""fa fa-skype""></i></a></li>
                                    <li class=""facebook""><a target=""_blank"" href=""http://www.facebook.com/""><i class=""fa fa-facebook""></i></a></li>
                                    <li class=""googleplus""><a target=""_blank"" href=""http://plus.google.com/""><i class=""fa fa-google-plus""></i></a></li>
                                </ul>
                            </div>

");
            EndContext();
            BeginContext(6594, 150, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n            </div>\r\n        </div>\r\n       \r\n           \r\n        </div>\r\n</section>\r\n");
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
