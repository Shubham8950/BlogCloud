#pragma checksum "F:\Code2NightCore\Code2Night\Code2Night\Views\Blog\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b42485c262b139d3f62cb097779fec692061114e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_index), @"mvc.1.0.view", @"/Views/Blog/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/index.cshtml", typeof(AspNetCore.Views_Blog_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42485c262b139d3f62cb097779fec692061114e", @"/Views/Blog/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.MyBlogs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Code2NightCore\Code2Night\Code2Night\Views\Blog\index.cshtml"
  
    ViewBag.Title = "Blogs | Code2Night.com";
    ViewBag.MetaDescription = "Welcome To Code2night, check out lur latest programming blogs with detailed description to help you out";
    ViewBag.MetaKeywords = "Code2Night,Blogs,Stripe,Slick,MVC,Exception Handling,Code,Programming,Tutotials,Slick Slider,IIS,Internet Information Services";
    ViewBag.Canonical = "https://www.code2night.com/Blog/index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    ViewBag.OpenGraphUrl = "https://www.code2night.com/Blog/index";
    ViewBag.OpenGraphDescription = "Welcome To Code2night, check out lur latest programming blogs with detailed description to help you out";
    ViewBag.OpenGraphTitle = "Blogs | Code2Night.com";

#line default
#line hidden
            BeginContext(771, 541, true);
            WriteLiteral(@"<style>
    .blogpost-body p span {
        display: inline-block;
        word-break: break-all;
    }
    .blogpost footer ul.links li a:nth-of-type(n+3){
        display: none;
    }
       
</style>
<script>
    $(document).ready(function () {
        $('.dropdown-toggle').dropdown();
    });
</script>
<div class=""page-intro"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ol class=""breadcrumb"">
                    <li><i class=""fa fa-home pr-10""></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1312, "\"", 1347, 1);
#line 33 "F:\Code2NightCore\Code2Night\Code2Night\Views\Blog\index.cshtml"
WriteAttributeValue("", 1319, Url.Action("index","Users"), 1319, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1348, 55, true);
            WriteLiteral(">Home</a></li>\r\n                    <li class=\"active\">");
            EndContext();
            BeginContext(1404, 13, false);
#line 34 "F:\Code2NightCore\Code2Night\Code2Night\Views\Blog\index.cshtml"
                                  Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 384, true);
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
                <div >
                    <div id=""lvCandidatestbl"" class=""masonry-grid row"">
                     <div id=""blogslist"">
                         ");
            EndContext();
            BeginContext(1802, 32, false);
#line 47 "F:\Code2NightCore\Code2Night\Code2Night\Views\Blog\index.cshtml"
                    Write(Html.Partial("_BlogsList",Model));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 411, true);
            WriteLiteral(@"
                     </div>   
                     </div>
                </div>
               
            </div>
        </div>
        <div class=""row"" style=""text-align:center""><div class=""container""> <div style=""margin:auto auto"" id=""pagination""></div></div></div>
    </div>
</section>

<script>
    $(document).ready(function () {
        //paginationTable();
       // LoadPartialView('");
            EndContext();
            BeginContext(2246, 30, false);
#line 61 "F:\Code2NightCore\Code2Night\Code2Night\Views\Blog\index.cshtml"
                      Write(Url.Action("BindBlogs","Blog"));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 914, true);
            WriteLiteral(@"', ""blogslist"", {});
        //paginationTable();
    }); function LoadPartialView(url, elem, postData) {
        ShowLoader();
        $.post(url, postData, function (result, status) {
            $(""#"" + elem).html('');
            $(""#"" + elem).html(result);
            HideLoader();
        });
    }
     function paginationTable() {
        var items = $(""#lvCandidatestbl #mydiv"");
        var numItems = items.length;
        var perPage = 9;
        items.slice(perPage).hide();
        $(""#pagination"").pagination({
            items: numItems,
            itemsOnPage: perPage,
            cssStyle: ""light-theme"",
            onPageClick: function (pageNumber) {
                var showFrom = perPage * (pageNumber - 1);
                var showTo = showFrom + perPage;
                items.hide().slice(showFrom, showTo).show();
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.DAL.Common.MyBlogs> Html { get; private set; }
    }
}
#pragma warning restore 1591
