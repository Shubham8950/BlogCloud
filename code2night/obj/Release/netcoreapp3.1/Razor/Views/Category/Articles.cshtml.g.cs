#pragma checksum "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e98a7f9cf879695724ddf9dc3f2803942130dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Articles), @"mvc.1.0.view", @"/Views/Category/Articles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Articles.cshtml", typeof(AspNetCore.Views_Category_Articles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e98a7f9cf879695724ddf9dc3f2803942130dca", @"/Views/Category/Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Articles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.Models.AritclesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/summernote.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminplugins/summernote/summernote.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminplugins/summernote/summernote.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
  
    ViewData["Title"] = "Articles";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(136, 207, true);
            WriteLiteral("\r\n<script type=\"text/javascript\" src=\"/plugins/jquery.min.js\"></script>\r\n<script src=\"/Scripts/jquery.validate.unobtrusive.js\"></script>\r\n<script src=\"/Scripts/jquery.validate.unobtrusive.min.js\"></script>\r\n");
            EndContext();
            BeginContext(343, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e98a7f9cf879695724ddf9dc3f2803942130dca5578", async() => {
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
            BeginContext(392, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(394, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e98a7f9cf879695724ddf9dc3f2803942130dca6830", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(469, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e98a7f9cf879695724ddf9dc3f2803942130dca8082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(532, 146, true);
            WriteLiteral("\r\n<section class=\"main-container\" style=\"margin-top: 0px;width: 100%\">\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 678, "\"", 686, 0);
            EndWriteAttribute();
            BeginContext(687, 138, true);
            WriteLiteral(" style=\"width:100%\">\r\n                <h2 class=\"title\">Topics</h2>\r\n                <hr>\r\n                <div class=\"form-horizontal\">\r\n");
            EndContext();
#line 21 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                     using (Html.BeginForm("SaveArticle", "Category", FormMethod.Post, new { @enctype = "multipart/form-data" }))
                    {

#line default
#line hidden
            BeginContext(979, 319, true);
            WriteLiteral(@"                        <div class=""col-md-12"" style=""display: flex;padding-bottom: 25px;"">
                            <div class=""col-md-6"">
                                <label for=""categoryid"" class=""col-sm-3 control-label"">Topic<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(1299, 142, false);
#line 26 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                           Write(Html.DropDownListFor(x => x.ArticleDetails.topicid, new SelectList(Model.GetTopicsTitle, "topicid", "title"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 270, true);
            WriteLiteral(@"
                            </div>
                            <div class=""col-md-6"">
                                <label for=""categoryid"" class=""col-sm-6 control-label"">Article Url<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(1712, 82, false);
#line 30 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                           Write(Html.TextBoxFor(x => x.ArticleDetails.articleurl, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 373, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12"" style=""display:flex"">
                            <div class=""col-md-6"">
                                <label for=""categoryid"" class=""col-sm-5 control-label"">Introduction<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(2168, 97, false);
#line 36 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                           Write(Html.TextAreaFor(x => x.ArticleDetails.topicArticleIntroduction, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 274, true);
            WriteLiteral(@"
                            </div>

                            <div class=""col-md-6"">
                                <label for=""categoryid"" class=""col-sm-4 control-label"">Article Title<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(2540, 85, false);
#line 41 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                           Write(Html.TextAreaFor(x => x.ArticleDetails.articletitle, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2625, 376, true);
            WriteLiteral(@"
                            </div>

                        </div>
                        <div class=""col-md-12"" style=""display:flex"">
                            <div class=""col-md-12"">
                                <label for=""categoryid"" class=""col-sm-6 control-label"">Article Body<span class=""text-danger small"">*</span></label>
                                ");
            EndContext();
            BeginContext(3002, 104, false);
#line 48 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                           Write(Html.TextAreaFor(x => x.ArticleDetails.ArticleBody, new { @class = "form-control", @id = "summernote" }));

#line default
#line hidden
            EndContext();
            BeginContext(3106, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3141, 45, false);
#line 49 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                           Write(Html.HiddenFor(x=>x.ArticleDetails.articleid));

#line default
#line hidden
            EndContext();
            BeginContext(3186, 510, true);
            WriteLiteral(@"
                            </div>


                        </div>
                        <div class=""col-md-12"" style=""display:flex"">
                            <div class=""col-md-6"">
                                <div class=""col-md-12 col-sm-12""> <input type=""button"" onclick=""Validate()"" style=""margin-top:31px;margin-bottom:31px"" name=""buttonsubmit"" id=""InsertCategory"" class=""btn btn-success"" value=""Submit Article""></div>
                            </div>
                        </div>
");
            EndContext();
#line 59 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                    }

#line default
#line hidden
            BeginContext(3719, 691, true);
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
                    Article Title
                </th>
                <th style=""width: 15%"">
                    Article Introduction
                </th>
            

                <th style=""width: 20%"">
                    Article Url
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 89 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
             foreach (var item in Model.GetArticles)
            {

#line default
#line hidden
            BeginContext(4479, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4552, 14, false);
#line 93 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                   Write(item.articleid);

#line default
#line hidden
            EndContext();
            BeginContext(4566, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4646, 17, false);
#line 96 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                   Write(item.articletitle);

#line default
#line hidden
            EndContext();
            BeginContext(4663, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4743, 29, false);
#line 99 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                   Write(item.topicArticleIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(4772, 101, true);
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4874, 15, false);
#line 103 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
                   Write(item.articleurl);

#line default
#line hidden
            EndContext();
            BeginContext(4889, 147, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"project-actions text-right\">\r\n                        <a class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5036, "\"", 5110, 1);
#line 106 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
WriteAttributeValue("", 5043, Url.Action("EditArticle", "Category", new { id = item.articleid }), 5043, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5111, 216, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-pen-square\">\r\n                            </i>\r\n                            Edit\r\n                        </a>\r\n                        <a class=\"btn btn-danger btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5327, "\"", 5403, 1);
#line 111 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
WriteAttributeValue("", 5334, Url.Action("DeleteArticle", "Category", new { id = item.articleid }), 5334, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5404, 281, true);
            WriteLiteral(@" onclick=""return confirm('Are you sure you want to Delete this article?')"">
                            <i class=""fas fa-trash"">
                            </i>
                            Delete
                        </a>
                    </td>
                </tr>
");
            EndContext();
#line 118 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
            }

#line default
#line hidden
            BeginContext(5700, 764, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script>

    $(document).ready(function () {
        $(""#summernote"").summernote({
            height: 300,                 // set editor height
            minHeight: null,             // set minimum height of editor
            maxHeight: null,             // set maximum height of editor
            focus: true,                  // set focus to editable area after initializing summernote
            callbacks: {
                onImageUpload: function (files) {
                    for (let i = 0; i < files.length; i++) {
                        UploadImage(files[i]);
                    }
                }
            }
        });
    });

     function UploadImage(file) {
        var url = '");
            EndContext();
            BeginContext(6465, 32, false);
#line 141 "E:\blogCloudGit\BlogCloud\code2night\Views\Category\Articles.cshtml"
              Write(Url.Action("UploadFile", "Blog"));

#line default
#line hidden
            EndContext();
            BeginContext(6497, 1802, true);
            WriteLiteral(@"';

        formData = new FormData();
        formData.append(""aUploadedFile"", file);
        $.ajax({
            type: 'POST',
            url: url,
            data: formData,
            cache: false,
            contentType: false,
            processData: false,
            success: function (FileUrl) {
               // alert(FileUrl);
                var imgNode = document.createElement('img');
                imgNode.src = FileUrl;
                $('#summernote').summernote('insertNode', imgNode);
            },
            error: function (data) {
                alert(data.responseText);
            }
        });
    }

    var Validate = function () {
        if ($(""#ArticleDetails_topicid"").val().trim() == """") {
            alert(""Please insert topic id "");
            return false;
        }
        else if ($(""#ArticleDetails_articleurl"").val().trim() == """") {
            alert(""Please insert article url "");
            return false;
        }
        else if (");
            WriteLiteral(@"$(""#ArticleDetails_topicArticleIntroduction"").val().trim() == """") {
            alert(""Please insert topic Article Introduction"");
            return false;
        }
        else if ($(""#ArticleDetails_articletitle"").val().trim() == """") {
            alert(""Please insert article title "");
            return false;
        }
        else if ($('#summernote').summernote('isEmpty')) {
            alert('Please insert article body');
            return false;
        }
        else if ($('#summernote').val().replace(/&nbsp;/g, '').replace(/ /g, '') == ""<p></p>"")
        {
            alert('Please do not insert white space in article body');
            return false;
        }
        else {
            $('form').submit();
        }
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
