#pragma checksum "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20c067b1e277fa4d09d2c1cfd798e458d6676119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogList_Index), @"mvc.1.0.view", @"/Views/BlogList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BlogList/Index.cshtml", typeof(AspNetCore.Views_BlogList_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c067b1e277fa4d09d2c1cfd798e458d6676119", @"/Views/BlogList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_BlogList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Code2Night.DAL.Common.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 2087, true);
            WriteLiteral(@"

<!-- Content Header (Page header) -->
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Blogs</h1>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>

<!-- Main content -->
<section class=""content"" style=""width:100%;"">

    <!-- Default box -->
    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""card-title"">Blogs</h3>
            <div class=""card-tools"">
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                    <i class=""fas fa-minus""></i>
                </button>
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" title=""Remove"">
                    <i class=""fas fa-times""></i>
                </button>
            </div>
        </div>
        <div class=""card-body p-0"">
            <table class=""table table-striped p");
            WriteLiteral(@"rojects"">
                <thead>
                    <tr>
                        <th style=""width: 1%"">
                            #
                        </th>
                        <th style=""width: 15%"">
                            Title
                        </th>
                        <th style=""width: 15%"">
                            Blog Date
                        </th>
                        <th style=""width: 15%"">
                            Blog URL
                        </th>
                        <th style=""width: 15%"">
                            Blog Month
                        </th>
                        <th style=""width: 15%"">
                            Tags
                        </th>
                        <th style=""width: 5%"">
                            Blog Body
                        </th>
                        <th style=""width: 20%"">
                           
                        </th>
                    </tr>
            ");
            WriteLiteral("    </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 66 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2304, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2401, 7, false);
#line 70 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2408, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2512, 10, false);
#line 73 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2522, 141, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                \r\n                                    ");
            EndContext();
            BeginContext(2664, 9, false);
#line 77 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2673, 172, true);
            WriteLiteral("\r\n                                \r\n                               \r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2846, 12, false);
#line 83 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                           Write(item.BlogUrl);

#line default
#line hidden
            EndContext();
            BeginContext(2858, 104, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td >\r\n                                ");
            EndContext();
            BeginContext(2963, 14, false);
#line 86 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                           Write(item.BlogMonth);

#line default
#line hidden
            EndContext();
            BeginContext(2977, 105, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td  >\r\n                                ");
            EndContext();
            BeginContext(3083, 9, false);
#line 89 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                           Write(item.Tags);

#line default
#line hidden
            EndContext();
            BeginContext(3092, 191, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td  style=\"white-space: nowrap;overflow: hidden;text-overflow: ellipsis;max-width: 200px;\">\r\n                                ");
            EndContext();
            BeginContext(3284, 13, false);
#line 92 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                           Write(item.BlogBody);

#line default
#line hidden
            EndContext();
            BeginContext(3297, 172, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td class=\"project-actions text-right\">\r\n                                <a class=\"btn btn-danger btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3469, "\'", 3532, 1);
#line 96 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
WriteAttributeValue("", 3476, Url.Action("Delete", "Blogs", new { Blogid = item.Id }), 3476, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3533, 255, true);
            WriteLiteral(">\r\n                                    <i class=\"fas fa-trash\">\r\n                                    </i>\r\n                                    Delete\r\n                                </a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 103 "F:\Code2NightCore\Code2Night\Code2Night\Views\BlogList\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3811, 161, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /.card-body -->\r\n    </div>\r\n    <!-- /.card -->\r\n\r\n</section>\r\n<!-- /.content -->\r\n");
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
