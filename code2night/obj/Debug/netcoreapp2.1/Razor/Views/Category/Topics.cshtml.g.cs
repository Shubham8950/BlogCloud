#pragma checksum "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab7ff3067735f7f60b252dd9e65122bd77ff81e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Topics), @"mvc.1.0.view", @"/Views/Category/Topics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Topics.cshtml", typeof(AspNetCore.Views_Category_Topics))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7ff3067735f7f60b252dd9e65122bd77ff81e4", @"/Views/Category/Topics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Topics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.Models.AritcleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
  
    ViewData["Title"] = "Topics";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(137, 371, true);
            WriteLiteral(@"
<script type=""text/javascript"" src=""/plugins/jquery.min.js""></script>
<script src=""/Scripts/jquery.validate.unobtrusive.js""></script>
<script src=""/Scripts/jquery.validate.unobtrusive.min.js""></script>
<section class=""main-container"" style=""        margin-top: 0px;
        width: 100%
"">

    <div class=""container"">
        <div class=""row"">
            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 508, "\"", 516, 0);
            EndWriteAttribute();
            BeginContext(517, 138, true);
            WriteLiteral(" style=\"width:100%\">\r\n                <h2 class=\"title\">Topics</h2>\r\n                <hr>\r\n                <div class=\"form-horizontal\">\r\n");
            EndContext();
#line 20 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                     using (Html.BeginForm("SaveTopic", "Category", FormMethod.Post, new { @enctype = "multipart/form-data" }))
                    {

#line default
#line hidden
            BeginContext(807, 299, true);
            WriteLiteral(@"                        <div class=""col-md-12"" style=""display:flex"">
                            <div class=""col-md-4"">
                                <label for=""categoryid"" class=""col-sm-3 control-label"">Category<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(1107, 215, false);
#line 25 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                           Write(Html.DropDownListFor(x => x.TopicDetail.categoryid, new SelectList(Model.GetCategories, "categoryid", "categoryname"), new { @Value = @Model.TopicDetail.categoryid, @required = "required", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1357, 56, false);
#line 26 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                           Write(Html.ValidationMessageFor(x => x.TopicDetail.categoryid));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 264, true);
            WriteLiteral(@"
                            </div>
                            <div class=""col-md-4"">
                                <label for=""categoryid"" class=""col-sm-3 control-label"">Title<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(1678, 133, false);
#line 30 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                           Write(Html.TextBoxFor(x => x.TopicDetail.title, new { @Value = @Model.TopicDetail.title, @required = "required", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1846, 51, false);
#line 31 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                           Write(Html.ValidationMessageFor(x => x.TopicDetail.title));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 268, true);
            WriteLiteral(@"
                            </div>
                            <div class=""col-md-4"">
                                <label for=""categoryid"" class=""col-sm-3 control-label"">Topic Url<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(2166, 139, false);
#line 35 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                           Write(Html.TextBoxFor(x => x.TopicDetail.topicurl, new { @Value = @Model.TopicDetail.topicurl, @required = "required", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2305, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2340, 54, false);
#line 36 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                           Write(Html.ValidationMessageFor(x => x.TopicDetail.topicurl));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2429, 40, false);
#line 37 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                           Write(Html.HiddenFor(x=>x.TopicDetail.topicid));

#line default
#line hidden
            EndContext();
            BeginContext(2469, 928, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group has-feedback"" style=""display:flex"">

                            <div class=""col-md-8 col-sm-12"">
                                <label for=""inputName"" class=""col-sm-3 control-label"">Image<span class=""text-danger small"">*</span></label>
                                <div class=""col-sm-12 col-md-12"">
                                    <input type=""file"" name=""documents"" />
                                </div>
                            </div>
                            <div class=""col-md-4 col-sm-12"">
                                <div class=""col-md-12 col-sm-12""> <input type=""button"" onclick=""Validate()"" style=""margin-top:31px;"" name=""buttonsubmit"" id=""InsertCategory""   class=""btn btn-primary"" value=""Save""></div>
                            </div>
                        </div>
");
            EndContext();
#line 52 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                    }

#line default
#line hidden
            BeginContext(3420, 721, true);
            WriteLiteral(@"                </div>
            </div>

            <!-- main end -->

        </div>
    </div>
</section>
<div class=""card-body p-0"">
    <table class=""table table-striped projects"">
        <thead>
            <tr>
                <th style=""width: 1%"">
                    #
                </th>
                <th style=""width: 15%"">
                    Title
                </th>
                <th style=""width: 15%"">
                    Topic Url
                </th>
                <th style=""width: 15%"">
                    Category
                </th>

                <th style=""width: 20%"">

                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 84 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
             foreach (var item in Model.GetTopics)
            {

#line default
#line hidden
            BeginContext(4208, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4281, 15, false);
#line 88 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                   Write(item.categoryid);

#line default
#line hidden
            EndContext();
            BeginContext(4296, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4376, 10, false);
#line 91 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                   Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(4386, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4466, 13, false);
#line 94 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                   Write(item.topicurl);

#line default
#line hidden
            EndContext();
            BeginContext(4479, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4559, 13, false);
#line 97 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
                   Write(item.Category);

#line default
#line hidden
            EndContext();
            BeginContext(4572, 147, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"project-actions text-right\">\r\n                        <a class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4719, "\"", 4789, 1);
#line 100 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
WriteAttributeValue("", 4726, Url.Action("EditTopic", "Category", new { id = item.topicid }), 4726, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4790, 217, true);
            WriteLiteral(" >\r\n                            <i class=\"fas fa-pen-square\">\r\n                            </i>\r\n                            Edit\r\n                        </a>\r\n                        <a class=\"btn btn-danger btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5007, "\"", 5079, 1);
#line 105 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
WriteAttributeValue("", 5014, Url.Action("DeleteTopic", "Category", new { id = item.topicid }), 5014, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5080, 279, true);
            WriteLiteral(@" onclick=""return confirm('Are you sure you want to Delete this topic?')"">
                            <i class=""fas fa-trash"">
                            </i>
                            Delete
                        </a>
                    </td>
                </tr>
");
            EndContext();
#line 112 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Topics.cshtml"
            }

#line default
#line hidden
            BeginContext(5374, 614, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script>
    var Validate = function () {
        if ($(""#TopicDetail_categoryid"").val().trim() == """") {
            alert(""Please insert category id "");
            return false;
        }
        else if ($(""#TopicDetail_title"").val().trim() == """") {
            alert(""Please insert title "");
            return false;
        }
        else if ($(""#TopicDetail_topicurl"").val().trim() == """") {
            alert(""Please insert topic url"");
            return false;
        }
        else {
            $('form').submit();
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.Models.AritcleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
