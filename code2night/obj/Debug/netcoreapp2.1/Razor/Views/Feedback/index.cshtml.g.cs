#pragma checksum "E:\BlogCloud\code2night\Views\Feedback\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c32c93602e49bd9edc18719c1872117bea4034e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_index), @"mvc.1.0.view", @"/Views/Feedback/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedback/index.cshtml", typeof(AspNetCore.Views_Feedback_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c32c93602e49bd9edc18719c1872117bea4034e8", @"/Views/Feedback/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Employed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "UnEmployed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\BlogCloud\code2night\Views\Feedback\index.cshtml"
  
    ViewBag.Title = "Lockdown Employment Feedback";

#line default
#line hidden
            BeginContext(62, 431, true);
            WriteLiteral(@"<meta name=""description"" content=""We are collecting data regarding employment effected during lockdown. This is just small feedback form that will be used for analysis purpose."" />
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-sm-12 col-lg-6 col-md-offset-3 mt-2"" style=""margin-top: 5%"">
            <div class=""comments-form"">
                <h2 class=""title"">Feedback</h2>
                ");
            EndContext();
            BeginContext(493, 2953, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32c93602e49bd9edc18719c1872117bea4034e86031", async() => {
                BeginContext(529, 1308, true);
                WriteLiteral(@"
                    <div class=""form-group has-feedback"">
                        <label for=""Name"">Your Name*</label>
                        <input type=""text"" class=""form-control"" id=""Name"" placeholder=""Name"" name=""Name"" required>
                        <i class=""fa fa-user form-control-feedback""></i>
                    </div>

                    <div class=""form-group has-feedback"">
                        <label for=""skill"">Your skill*</label>
                        <input type=""text"" class=""form-control"" id=""Skill"" placeholder=""Skills"" name=""Skill"" required>
                        <i class=""fa fa-pencil form-control-feedback""></i>
                    </div>
                    <div class=""form-group has-feedback"">
                        <label for=""Experience"">Experience*</label>
                        <input type=""text"" class=""form-control"" id=""Experience"" placeholder=""Experience"" name=""Experience"" required>
                        <i class=""fa fa-pencil form-control-feedback""></");
                WriteLiteral(@"i>
                    </div>
                    <div class=""form-group has-feedback"">
                        <label for=""Employment"">Employement Status</label>
                        <select name=""Employment"" class=""form-control"" id=""Employment"">
                            ");
                EndContext();
                BeginContext(1837, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32c93602e49bd9edc18719c1872117bea4034e87815", async() => {
                    BeginContext(1854, 20, true);
                    WriteLiteral("Please Select Status");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1883, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1913, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32c93602e49bd9edc18719c1872117bea4034e89323", async() => {
                    BeginContext(1938, 8, true);
                    WriteLiteral("Employed");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1955, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1985, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32c93602e49bd9edc18719c1872117bea4034e810818", async() => {
                    BeginContext(2012, 11, true);
                    WriteLiteral("Un-Employed");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2032, 1407, true);
                WriteLiteral(@"
                        </select>

                    </div>
                    <div class=""form-group has-feedback"">
                        <label for=""Job"">Have you lost your job during lockdown ? *</label>
                        <input type=""radio"" name=""Job"" class=""Job"" value=""Yes"">Yes
                        <input type=""radio"" name=""Job"" class=""Job"" value=""No""> No
                    </div>
                    <div class=""form-group has-feedback"">
                        <label for=""JobIndustry"">Specify Industry if looking for job (Optional)</label>
                        <input type=""text"" class=""form-control"" id=""JobIndustry"" placeholder="""" name=""JobIndustry"">
                        <i class=""fa fa-pencil form-control-feedback""></i>
                    </div>
                    <div class=""form-group has-feedback"">
                        <label for=""Email"">Specify Email if looking for job (Optional)</label>
                        <input type=""text"" class=""form-control"" id=""Em");
                WriteLiteral(@"ail"" placeholder="""" name=""Email"">
                        <i class=""fa fa-envelope-o form-control-feedback""></i>
                    </div>
                    <input type=""button"" value=""Submit"" onclick=""SaveFeedback()"" class=""btn btn-default"">
                    <a onclick=""Share()"" class=""btn btn-default""><i class=""fa fa-share""></i> Share With Friends</a>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(3446, 268, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<script>
    var Share = function () {
        window.location.href = 'https://wa.me/?text=' + window.location.href;
    }
    var SaveFeedback=function()
    {
        var promises = GetAjaxDataPromise('");
            EndContext();
            BeginContext(3715, 38, false);
#line 65 "E:\BlogCloud\code2night\Views\Feedback\index.cshtml"
                                      Write(Url.Action("SaveFeedback", "Feedback"));

#line default
#line hidden
            EndContext();
            BeginContext(3753, 718, true);
            WriteLiteral(@"', { Name: $(""#Name"").val(), Experience: $(""#Experience"").val(), Skill: $(""#Skill"").val(), Job: $("".Job:checked"").val(), Email: $(""#Email"").val(), JobIndustry: $(""#JobIndustry"").val(), Employment: $(""#Employment"").val() });
            promises.done(function (response) {
                    Swal.fire({
                        position: 'top-center',
                        type: 'success',
                        title: ""Thanks for your Feedback !"",
                        showConfirmButton: false,
                        timer: 3000
                });
                $('input,select').val('');
                $('.job').prop(""checked"", false)
                
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
