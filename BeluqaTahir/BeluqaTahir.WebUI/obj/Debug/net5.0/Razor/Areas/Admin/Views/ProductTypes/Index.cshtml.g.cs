#pragma checksum "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d693f606c8d492b3ec9657279ad8bdc9b2bf8846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductTypes_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductTypes/Index.cshtml")]
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
#line 4 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.Core.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.BlogMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.ProductType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BeluqaTahir.Applications.HappyClientss;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d693f606c8d492b3ec9657279ad8bdc9b2bf8846", @"/Areas/Admin/Views/ProductTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c64a901c442da5f4c03a601b5c229cb77470b74", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<ProductTypes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
            WriteLiteral("</div>\r\n\r\n<div style=\"display:flex\">\r\n    <h1>Icons Layout</h1>\r\n\r\n\r\n</div>\r\n<a style=\"margin-left:15px\" class=\"btn btn-warning\">Education Count:");
#nullable restore
#line 16 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
                                                               Write(Model.Items.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n<div class=\"col-10\">\r\n    <table class=\"table table-striped\" border=\"1\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">Icon Name</th>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d693f606c8d492b3ec9657279ad8bdc9b2bf88468884", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-plus\"></i>\r\n                        Create New\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 39 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d693f606c8d492b3ec9657279ad8bdc9b2bf884611048", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-pencil-alt\"></i>\r\n                            Edit\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n                        <a class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1210, "\"", 1250, 6);
            WriteAttributeValue("", 1220, "remove(", 1220, 7, true);
#nullable restore
#line 49 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
WriteAttributeValue("", 1227, item.Id, 1227, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1235, ",", 1235, 1, true);
            WriteAttributeValue(" ", 1236, "\'", 1237, 2, true);
#nullable restore
#line 49 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
WriteAttributeValue("", 1238, item.Name, 1238, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1248, "\')", 1248, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-trash-alt\"></i>\r\n\r\n                            Delete\r\n                        </a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d693f606c8d492b3ec9657279ad8bdc9b2bf884615152", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d693f606c8d492b3ec9657279ad8bdc9b2bf884616252", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script>

        function remove(id, name) {

            swal({
                title: ""Eminsiniz?"",
                text: `Testik etdiyiniz teqdirde  '${name}' sistemden  silinecek!`,
                type: ""warning"",
                showCancelButton: true,
                confirmButtonClass: ""btn-danger"",
                buttons: [""No"", ""Yes""]
            }).then(
                function (isConfirm) {
                    if (isConfirm) {


                        $.ajax({
                            url: '");
#nullable restore
#line 86 "C:\Users\emin.novruzov\Desktop\xxxxxxxx\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Areas\Admin\Views\ProductTypes\Index.cshtml"
                             Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                            type: 'POST',
                            data: { id },
                            contentType: 'application/x-www-form-urlencoded', // ne tip  gedecek?   2side model binding rolnu oynayir datani back gondermek ucun isdifade edilir  yeni back gonderilmeye xirmet edilir
                            dataType: 'json',
                    beforeSend: function () {
                        console.log(""sorgudan evvel"")   // loadir acmaq

                    },
                    success: function (response) {   // sorgunun neticesi ugurlu olsa
                        console.log(response)

                        if (response.error == false) {

                            toastr.success(response.Message, ""Ugurludur"");
                            window.location.reload();

                        } else {
                            toastr.error(response.Message, ""xeta"");

                        }
                    },
                            error: functio");
                WriteLiteral(@"n (response) {   // sorgunun neticesi ugursuz olsa
                                console.log(response)
                    },


                }).always(function () {
                         console.log(""sorgudan sonra"")  //loadir baglamaq

                });

                    }
                });
        };
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d693f606c8d492b3ec9657279ad8bdc9b2bf884619790", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<ProductTypes>> Html { get; private set; }
    }
}
#pragma warning restore 1591