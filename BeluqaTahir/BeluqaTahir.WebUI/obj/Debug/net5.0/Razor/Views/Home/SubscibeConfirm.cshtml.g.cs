#pragma checksum "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\SubscibeConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc994ee4cea1219a83095c1370d9172b333a03a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SubscibeConfirm), @"mvc.1.0.view", @"/Views/Home/SubscibeConfirm.cshtml")]
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
#line 3 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.DataContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc994ee4cea1219a83095c1370d9172b333a03a3", @"/Views/Home/SubscibeConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f1fe3f9fbac11e2f0d8e005553f09f8743845f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SubscibeConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\SubscibeConfirm.cshtml"
  
    var m = ViewBag.ms as Tuple<bool, string>;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<section class=\"page-content mt-10 pt-7\">\r\n    <section class=\"contact-section\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\SubscibeConfirm.cshtml"
                     if (m.Item1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger text-white\">\r\n                            ");
#nullable restore
#line 18 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\SubscibeConfirm.cshtml"
                       Write(m.Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 20 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\SubscibeConfirm.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success text-white\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\SubscibeConfirm.cshtml"
                       Write(m.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\eltun.ismayilov\Desktop\Beluqa-Tahir-BackEnd\Beluqa-Tahir-BackEnd\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\SubscibeConfirm.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n\r\n        <script>\r\n            $(document).ready(function () {\r\n                setTimeout(\"window.location.pathname = \\\"home/Signin\\\";\", 2000);\r\n            })</script>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
