#pragma checksum "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33107724ecf18df6d45abddacf00e1a0cdd6ec95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__Comment), @"mvc.1.0.view", @"/Views/Blog/_Comment.cshtml")]
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
#line 3 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.DataContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33107724ecf18df6d45abddacf00e1a0cdd6ec95", @"/Views/Blog/_Comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f1fe3f9fbac11e2f0d8e005553f09f8743845f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog__Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPostComment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/images/blog/comments/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<li");
            BeginWriteAttribute("class", " class=\'", 29, "\'", 93, 2);
            WriteAttributeValue("", 37, "comment", 37, 7, true);
#nullable restore
#line 3 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue(" ", 44, Model.ParentId != null?"comment-sub ml-10":"", 45, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", "  id=\"", 94, "\"", 112, 2);
            WriteAttributeValue("", 100, "#c-", 100, 3, true);
#nullable restore
#line 3 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue("", 103, Model.Id, 103, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-comment-id=\"");
#nullable restore
#line 3 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
                                                                                                    Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <figure class=\"comment-media\">\r\n        <a href=\"#\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "33107724ecf18df6d45abddacf00e1a0cdd6ec956512", async() => {
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
            WriteLiteral("\r\n        </a>\r\n    </figure>\r\n    <div class=\"comment-body\">\r\n        <div class=\"comment-user\">\r\n            <h4><a href=\"#\">");
#nullable restore
#line 11 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
                       Write(Model.CreateByUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n            <span class=\"comment-date\">");
#nullable restore
#line 12 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
                                  Write(Model.CreateData.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n        </div>\r\n\r\n        <div class=\"comment-content mb-2\">\r\n");
#nullable restore
#line 17 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
             if (Model.ParentId != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 681, 2);
            WriteAttributeValue("", 663, "#c-", 663, 3, true);
#nullable restore
#line 19 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue("", 666, Model.ParentId, 666, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            WriteLiteral("@");
#nullable restore
#line 19 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
                                           Write($"{Model.Parent.CreateByUser?.UserName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span>&nbsp; &nbsp;</span>\r\n");
#nullable restore
#line 20 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                ");
#nullable restore
#line 22 "C:\Users\User\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Blog\_Comment.cshtml"
           Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <a href=\"#\" class=\"btn btn-link btn-reveal-right btn-comment-reply\">\r\n            REPLY<i class=\"d-icon-arrow-right\"></i>\r\n        </a>\r\n    </div>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPostComment> Html { get; private set; }
    }
}
#pragma warning restore 1591
