#pragma checksum "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ContactPost\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b1a1a06479091e78f956086952c4620f607677"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactPost_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactPost/Details.cshtml")]
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
#nullable restore
#line 4 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.Core.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.BlogMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.ProductType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.HappyClientss;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b1a1a06479091e78f956086952c4620f607677", @"/Areas/Admin/Views/ContactPost/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c64a901c442da5f4c03a601b5c229cb77470b74", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ContactPost_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Answer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:16px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ContactPost\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center;color:red;"">ContactPost</h1>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""inputGroup-sizing-default"">Name</span>
                </div>
                <input type=""text"" disabled class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 488, "\"", 513, 1);
#nullable restore
#line 19 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ContactPost\Details.cshtml"
WriteAttributeValue("", 502, Model.Name, 502, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Default"" aria-describedby=""inputGroup-sizing-default"">
            </div>
            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""inputGroup-sizing-default"">Email</span>
                </div>
                <input type=""text"" disabled class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 882, "\"", 908, 1);
#nullable restore
#line 25 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ContactPost\Details.cshtml"
WriteAttributeValue("", 896, Model.Email, 896, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Default"" aria-describedby=""inputGroup-sizing-default"">
            </div>
            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""inputGroup-sizing-default"">Subject</span>
                </div>
                <input type=""text"" disabled class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1279, "\"", 1307, 1);
#nullable restore
#line 31 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ContactPost\Details.cshtml"
WriteAttributeValue("", 1293, Model.Subject, 1293, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Default"" aria-describedby=""inputGroup-sizing-default"">
            </div>
            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""inputGroup-sizing-default"">Content</span>
                </div>
                <input type=""text"" disabled class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1678, "\"", 1706, 1);
#nullable restore
#line 37 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ContactPost\Details.cshtml"
WriteAttributeValue("", 1692, Model.Content, 1692, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Default\" aria-describedby=\"inputGroup-sizing-default\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<dd class=\"col-4 \" id=\"form-answer\" style=\"display:none\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b1a1a06479091e78f956086952c4620f60767711442", async() => {
                WriteLiteral("\r\n        <textarea name=\"Answer\" class=\"form-control\" placeholder=\"birseyler yazin\"></textarea>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31b1a1a06479091e78f956086952c4620f60767711813", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ContactPost\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <button class=\"btn btn-primary\">Cavabla</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</dd>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b1a1a06479091e78f956086952c4620f60767715054", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a  class=\"btn btn-primary\" id=\"btnReply\">Reply</a>\r\n</div>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n\r\n            $(\'#btnReply\').click(function (e) {\r\n                e.preventDefault();\r\n\r\n                $(\'#form-answer\').show();\r\n\r\n            })\r\n\r\n        })\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
