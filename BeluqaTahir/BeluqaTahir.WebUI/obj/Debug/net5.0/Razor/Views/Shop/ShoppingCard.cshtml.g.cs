#pragma checksum "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4865ec198fc2a0fc8d4d2af3044f160f734870a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ShoppingCard), @"mvc.1.0.view", @"/Views/Shop/ShoppingCard.cshtml")]
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
#line 2 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.DataContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.FormModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4865ec198fc2a0fc8d4d2af3044f160f734870a9", @"/Views/Shop/ShoppingCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae0466d22a7b221d4c8dd6734815db5b666e929c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ShoppingCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Signin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-2 pl-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
  
    ViewData["Title"] = "ShoppingCard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""site-navbar-wrap"">
    <div class=""site-navbar-top"">
        <div class=""container py-3"">
            <div class=""row align-items-center"">
                <div class=""col-6"">
                    <div class=""d-flex mr-auto"">
                        <a href=""#"" class=""d-flex align-items-center mr-4"">
                            <span class=""icon-envelope mr-2""></span>
                            <span class=""d-none d-md-inline-block"">eltunhi@code.edu.az</span>
                        </a>
                        <a href=""#"" class=""d-flex align-items-center mr-auto"">
                            <span class=""icon-phone mr-2""></span>
                            <span class=""d-none d-md-inline-block"">+994 77 566 31 61</span>
                        </a>
                    </div>
                </div>
                <div class=""col-6 text-right"">
                    <div class=""mr-auto"">

");
#nullable restore
#line 26 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a98902", async() => {
                WriteLiteral("<span>");
#nullable restore
#line 30 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
                                                                                           Write(User.Identity.Name.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a910774", async() => {
                WriteLiteral("<span>Logout</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a912606", async() => {
                WriteLiteral("<span>LOG IN</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a914092", async() => {
                WriteLiteral("<span>SING UP</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <a href=""#"" class=""p-2 pl-0""><span class=""icon-twitter""></span></a>
                        <a href=""#"" class=""p-2 pl-0""><span class=""icon-facebook""></span></a>
                        <a href=""#"" class=""p-2 pl-0""><span class=""icon-linkedin""></span></a>
                        <a href=""#"" class=""p-2 pl-0""><span class=""icon-instagram""></span></a>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class=""site-navbar site-navbar-target js-sticky-header"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-2"">
                    <h1 class=""my-0 site-logo"">
                        <a class=""LIQUOR"" href=""index.html"">LIQUOR STORE</a>
                    </h1>
                </div>
                <div class=""col-10"">
                    <nav class=""site-navigation text-right"" role=""navigation"">
                        <div class=""container"">
            ");
            WriteLiteral(@"                <div class=""d-inline-block d-lg-none ml-md-0 mr-auto py-3""><a href=""#"" class=""site-menu-toggle js-menu-toggle text-white""><span style=""color: chocolate;"" class=""icon-menu h3""></span></a></div>

                            <ul class=""site-menu main-menu js-clone-nav d-none d-lg-block"">
                                <li>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a917332", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a918892", async() => {
                WriteLiteral("About");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n\r\n                                <li class=\"active\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a920474", async() => {
                WriteLiteral("Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a922037", async() => {
                WriteLiteral("Blog");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4865ec198fc2a0fc8d4d2af3044f160f734870a923597", async() => {
                WriteLiteral("Contact");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </li>

                                <li>
                                    <a href=""#contact-section"" class=""nav-link"">
                                        <span><i class=""fas fa-shopping-basket""></i></span>
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""hero"" style=""        background-image: url(https://preview.colorlib.com/theme/liquorstore/images/xbg_2.jpg.pagespeed.ic.CNGkvk0ls9.webp);
        height: 400px;"">
    <div class=""textone"" data-aos=""fade-up"">
        <p style=""text-align: center;padding-top: 159px;font-size: 20px;font-weight: 700;"">
            <span>
                <a href=""index.html"" style=""color: gray;"">
                    HOME
                    <i class=""fa fa-chevron-right""></i>
                </a>
     ");
            WriteLiteral(@"       </span>
            <span>
                PRODUCTS
                <i class=""fa fa-chevron-right""></i>
            </span>
            <span>
                PRODUCTS CARD
                <i class=""fa fa-chevron-right""></i>
            </span>
        </p>
        <h2 style=""text-align: center;color:white;font-size: 90px;"">Product Single</h2>
    </div>
</div>


<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""table-wrap"">
                <table class=""table"">
                    <thead class=""thead-primary"">
                        <tr>
                            <th>Image</th>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Count</th>
                            <th>Total</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 137 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"alert\" role=\"alert\">\r\n\r\n                                <td>\r\n                                    <img style=\"height:100px;width:100px;\"");
            BeginWriteAttribute("src", " src=\"", 6161, "\"", 6197, 2);
            WriteAttributeValue("", 6167, "/assets/images/", 6167, 15, true);
#nullable restore
#line 142 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
WriteAttributeValue("", 6182, item.ImagePati, 6182, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6198, "\"", 6204, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </td>\r\n                                <td>\r\n                                    <div style=\"margin-left:17px\" class=\"email\">\r\n                                        <span>");
#nullable restore
#line 146 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </td>\r\n\r\n                                <td style=\"padding-left:25px\">");
#nullable restore
#line 150 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                                <td class=""quantity"">
                                    <div style=""padding-left:30px;color:red"" class=""input-group"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number""");
            BeginWriteAttribute("value", " value=\"", 6870, "\"", 6889, 1);
#nullable restore
#line 154 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
WriteAttributeValue("", 6878, item.Count, 6878, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\" max=\"100\">\r\n                                    </div>\r\n                                </td>\r\n");
            WriteLiteral(@"                                <td>
                                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                        <span aria-hidden=""true""><i class=""fa fa-close""></i></span>
                                    </button>
                                </td>
                            </tr>
");
#nullable restore
#line 164 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\BeluqaTahir\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Shop\ShoppingCard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class=""row justify-content-end"">
            <div class=""col col-lg-5 col-md-6 mt-5 cart-wrap ftco-animate"">
                <div class=""cart-total mb-3"">
                    <h3>Cart Totals</h3>
                    <p class=""d-flex"">
                        <span>Subtotal</span>
                        <span>$20.60</span>
                    </p>
                    <p class=""d-flex"">
                        <span>Delivery</span>
                        <span>$0.00</span>
                    </p>
                    <p class=""d-flex"">
                        <span>Discount</span>
                        <span>$3.00</span>
                    </p>
                    <hr>
                    <p class=""d-flex total-price"">
                        <span>Total</span>
                        <span>$17.60</span>
                    </p>
                </div>
                <p class=""text");
            WriteLiteral("-center\"><a href=\"checkout.html\" class=\"btn btn-primary py-3 px-4\">Proceed to Checkout</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral(@"

    <style>

        .ftco-section {
            padding: 6em 0;
            position: relative;
        }

        .table thead.thead-primary {
            background: #b7472a;
            border-radius: 4px;
        }

        .table thead th {
            border: none;
            padding: 30px;
            font-size: 20px;
            font-weight: 500;
            color: white;
        }

        .alert {
            position: relative;
            padding: 0.75rem 1.25rem;
            margin-bottom: 1rem;
            border: 1px solid transparent;
            border-radius: 0.25rem;
        }

        .cart-total {
            width: 100%;
            display: block;
            border: 1px solid rgba(0, 0, 0, 0.05);
            padding: 20px;
        }

            .cart-total h3 {
                font-size: 24px;
                margin-bottom: 20px;
                font-weight: 500;
            }

            .cart-total p {
                width: 100%;
  ");
                WriteLiteral("              display: block;\r\n            }\r\n\r\n                .cart-total p span {\r\n                    display: block;\r\n                    width: 50%;\r\n                }\r\n    </style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
