#pragma checksum "C:\Users\User\source\repos\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23fbfcf4840c720d98c9b1584958c900f03ae7bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 2 "C:\Users\User\source\repos\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\BeluqaTahir\BeluqaTahir.WebUI\Views\_ViewImports.cshtml"
using BeluqaTahir.Domain.Model.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23fbfcf4840c720d98c9b1584958c900f03ae7bd", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3ec558be82e26d2f7bfa6497fe2e6aa7e7af1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\BeluqaTahir\BeluqaTahir.WebUI\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

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
                        <a href=""login.html"" class=""p-2 pl-0""><span>LOG IN</span></a>
        ");
            WriteLiteral(@"                <a href=""sinup.html"" class=""p-2 pl-0""><span>SING UP</span></a>
                        <a href=""#"" class=""p-2 pl-0""><span class=""icon-twitter""></span></a>
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
                    <nav class=""site-navigation text-right"" r");
            WriteLiteral(@"ole=""navigation"">
                        <div class=""container"">
                            <div class=""d-inline-block d-lg-none ml-md-0 mr-auto py-3""><a href=""#"" class=""site-menu-toggle js-menu-toggle text-white""><span style=""color: chocolate;"" class=""icon-menu h3""></span></a></div>

                            <ul class=""site-menu main-menu js-clone-nav d-none d-lg-block"">
                                <li>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23fbfcf4840c720d98c9b1584958c900f03ae7bd8168", async() => {
                WriteLiteral("Home");
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
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"active\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23fbfcf4840c720d98c9b1584958c900f03ae7bd9744", async() => {
                WriteLiteral("About");
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
            WriteLiteral("\r\n                                </li>\r\n\r\n                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23fbfcf4840c720d98c9b1584958c900f03ae7bd11308", async() => {
                WriteLiteral("Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23fbfcf4840c720d98c9b1584958c900f03ae7bd12871", async() => {
                WriteLiteral("Blog");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23fbfcf4840c720d98c9b1584958c900f03ae7bd14431", async() => {
                WriteLiteral("Contact");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                ABOUT US
                <i class=""fa fa-chevron-right""></i>
            </span>
        </p>
        <h2 style=""text-align: center;color:white;font-size: 90px;"">About Us</h2>
    </div>
</div>


<!-- Services -->
<div class=""info"">

    <div class=""container baby"">
        <a data-aos=""fade-up"" class=""card2 col-md-4"" href=""#"">
            <h3>ONLINE SUPPORT 24/7</h3>
            <p class=""small"">
                A small river named Duden flows by their place and supplies it with the necessary regelialia.

            </p>

            <div class=""go-corner"" href=""#"">
                <div class=""go-arrow"">

                </div>
            </div>
        </a>
        <a data-aos=""fade-up"" class=""card2 col-md-4"" href=""#"">
            <h3>
                MONEY BACK GUARANTEE
            </h3>
            <p class=""small"">A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>

       ");
            WriteLiteral(@"     <div class=""go-corner"" href=""#"">
                <div class=""go-arrow"">
                </div>
            </div>
        </a>
        <a data-aos=""fade-up"" class=""card2 col-md-4"" href=""#"">
            <h3>
                FREE SHIPPING & RETURN
            </h3>
            <p class=""small"">
                A small river named Duden flows by their place and supplies it with the necessary regelialia.

                .
            </p>

            <div class=""go-corner"" href=""#"">
                <div class=""go-arrow"">

                </div>
            </div>
        </a>
    </div>

</div>

<!-- New Taste -->

<div class=""container"">
    <div data-aos=""fade-right"" class=""row mt-5"">
        <div style=""        background-image: url(https://preview.colorlib.com/theme/liquorstore/images/xbg_2.jpg.pagespeed.ic.CNGkvk0ls9.webp);
        background-size: cover;"" class=""col-md-6 yeah"">
            
        </div>
        <div data-aos=""fade-up"" class=""col-md-6 yeah"">

     ");
            WriteLiteral(@"       <span>Since 1905</span>
            <h2>Desire Meets A New Taste</h2>
            <p>
                A small river named Duden f
                lows by their place and supplies it with the
                necessary regelialia. It is a paradisematic country,
                in which roasted parts of sentences fly into your mouth.
            </p>
            <p>
                On her way she met a copy. The copy warned the Little Blind Text, that where it came from it would have been rewritten a thousand times and everything that was left from its origin would be the word ""and"" and the Little Blind Text should turn around and return to its own, safe country.

            </p>
            <div class=""count"">
                <p class=""count"">115</p>
                <p class=""fak"">Years of Experience In Business</p>
            </div>

        </div>
    </div>
</div>





<!-- karusel -->

<div style=""background-image:url(./assets/images/gagasim-11.jpg);"" class=""karusel"">

");
            WriteLiteral(@"    <p>Testimonial</p>
    <h2>Happy Clients</h2>

    <div class=""container"">

        <div class=""col-12"">

            <div class=""container1"">
                <div class=""faders"">
                    <div class=""left""></div>
                    <div class=""right""></div>
                </div>

                <div class=""items"">
                    <div class=""entry"">
                        <p class=""name"">Ismayilov Eltun</p>
                        <img class=""faking"" src=https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto =format%2Ccompress&cs =tinysrgb&dpr =2&h =650&w =940"" alt=""Smiling person"" />
                        <p class=""quote"">""Ye ic kayf ele 5 gunluk dunyadi""</p>
                    </div>
                    <div class=""entry"">
                        <p class=""name"">Anar Memmedov</p>
                        <img class=""faking"" src=""https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=format%2Ccompress&cs=tinysrgb&dpr=2&h=650&w=940"" ");
            WriteLiteral(@"alt=""Smiling person"" />
                        <p class=""quote"">""Seninkide yasayis deyil haa..""</p>
                    </div>
                    <div class=""entry"">
                        <p class=""name"">Ilham Bagiraz</p>
                        <img class=""faking"" src=""https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=format%2Ccompress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""Smiling person"" />
                        <p class=""quote"">""Gaga siqaret verde ""</p>
                    </div>
                    <div class=""entry"">
                        <p class=""name"">Bahman Memmedov</p>
                        <img class=""faking"" src=""https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=format%2Ccompress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""Smiling person"" />
                        <p class=""quote"">""Gagasim bir canciyer 2 ...""</p>
                    </div>
                    <div class=""entry"">
                        <p class=""name"">Qubad Memmedov</p>
     ");
            WriteLiteral(@"                   <img class=""faking"" src=""https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=format%2Ccompress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""Smiling person"" />
                        <p class=""quote"">""Meni narahat elemiyin (kayfadadi)""</p>
                    </div>
                    <div class=""entry"">
                        <p class=""name"">Yusif Bagiraz</p>
                        <img class=""faking"" src=""https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=format%2Ccompress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""Smiling person"" />
                        <p class=""quote"">""Gaga ana seyfe yazmisam""</p>
                    </div>
                    <div class=""entry"">
                        <p class=""name"">Samxal Memmedov</p>
                        <img class=""faking"" src=""https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=format%2Ccompress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""Smiling person"" />
                        <p class=""quot");
            WriteLiteral(@"e"">""Gaga bomba seydi ha""</p>
                    </div>
                    <div class=""entry"">
                        <p class=""name"">John Doe</p>
                        <img class=""faking"" src=""https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=format%2Ccompress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""Smiling person"" />
                        <p class=""quote"">""Man, I think this app freaking rocks and stuff. Dude.""</p>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>

<!-- //countup -->

<div style=""text-align: center !important;"" class=""up "">
    <div class=""container "">
        <div class=""row mt-5"">
            <div class=""col-lg-3   col-md-6 upin "">
                <div class=""counupres"">
                    <p aria-colcount=""countupcik1"" style=""color: #b7472a;font-size: 40px;font-style: italic;font-weight: 700;"" class=""count"">100</p>
                    <span class=""countupcik"" style=""font-size:18px;color:black");
            WriteLiteral(@";font-weight: 700;margin-top: 10px;display: inline-block;"">KINDS OF LIQUOR</span>

                </div>
            </div>
            <div class=""col-lg-3   col-md-6 upin"">
                <div class=""counupres"">
                    <p aria-colcount=""countupcik1"" style=""color: #b7472a;font-size: 40px;font-style: italic;font-weight: 700;"" class=""count"">115</p>
                    <span class=""countupcik"" style=""font-size:18px;color:black;font-weight: 700;margin-top: 10px;display: inline-block;"">YEARS OF Experience</span>

                </div>
            </div>
            <div class=""col-lg-3  col-md-6 upin"">
                <div class=""counupres"">
                    <p aria-colcount=""countupcik1"" style=""color: #b7472a;font-size: 40px;font-style: italic;font-weight: 700;"" class=""count"">113</p>
                    <span class=""countupcik"" style=""font-size:18px;color:black;font-weight: 700;margin-top: 10px;display: inline-block;"">
                        KINDS OF LIQUOR
                   ");
            WriteLiteral(@" </span>

                </div>
            </div>
            <div class=""col-lg-3 col-md-6 upin"">
                <div class=""counupres"">
                    <p aria-colcount=""countupcik1"" style=""color: #b7472a;font-size: 40px;font-style: italic;font-weight: 700;"" class=""count"">40</p>
                    <span class=""countupcik"" style=""font-size:18px;color:black;font-weight: 700;margin-top: 10px;display: inline-block;"">
                        OUR BRANCHES
                    </span>

                </div>
            </div>

        </div>
    </div>
</div>
");
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
