#pragma checksum "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57114435dbe66809867d9cb6ff83a1b44198e135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\_ViewImports.cshtml"
using Sailor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\_ViewImports.cshtml"
using Sailor.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57114435dbe66809867d9cb6ff83a1b44198e135", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9a17b6d101bf5f70e6d3e1eac72d4146d3a30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section id=\"slider-section\">\r\n        <div class=\"slider\">\r\n");
#nullable restore
#line 9 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
              
                var count = 0;

                foreach (Slider slider in Model.Sliders)
                {
                    count++;
                    string sliderOrder = "";

                    if (count == 1)
                    {
                        sliderOrder = "items active";
                    }
                    else
                    {
                        sliderOrder = "items";
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 620, "\"", 640, 1);
#nullable restore
#line 26 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
WriteAttributeValue("", 628, sliderOrder, 628, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 641, "\"", 707, 4);
            WriteAttributeValue("", 649, "background-image:", 649, 17, true);
            WriteAttributeValue(" ", 666, "url(/assets/Image/Slider/", 667, 26, true);
#nullable restore
#line 26 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
WriteAttributeValue("", 692, slider.Image, 692, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 705, ");", 705, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""false-div d-flex align-items-center"">
                            <div class=""manage"">
                                <i class=""fa-solid fa-chevron-left""></i>
                                <i class=""fa-solid fa-chevron-right""></i>
                            </div>
                            <div class=""slider-info text-center text-light"">
                                <h2>");
#nullable restore
#line 33 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                               Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 35 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                               Write(slider.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1318, "\"", 1325, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 41 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </section>
    <section id=""about-section"" class=""py-5"">
        <div class=""container"">
            <div class=""row"">
                <div class=""about-desc col-lg-6"">
                    <h2>EUM IPSAM LABORUM DELENITI VELITENA</h2>
                    <p>
                        Voluptatem dignissimos provident quasi corporis voluptates sit assum perenda sruen jonee trave
                    </p>
                </div>
                <div class=""plans col-lg-6"">
                    <p>
                        Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit
                        in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat
                        cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum
                    </p>
                    <p>Ullamco laboris nisi ut aliquip ex ea commodo consequa</p>
                    <p>Duis aute irure dolor");
            WriteLiteral(@" in reprehenderit in voluptate velit</p>
                    <p>Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in</p>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                </div>
            </div>
        </div>
    </section>
    <section id=""brand-section"" class=""bg-light py-3"">
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 71 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                 foreach (Brand brand in Model.Brands)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-2 col-md-6 col-sm-6 col-6\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3207, "\"", 3246, 2);
            WriteAttributeValue("", 3213, "/assets/Image/Brands/", 3213, 21, true);
#nullable restore
#line 74 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
WriteAttributeValue("", 3234, brand.Image, 3234, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3247, "\"", 3253, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    <section id=\"card-section\" class=\"py-5\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 83 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                 foreach (Card card in Model.Cards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"cards col-lg-6\">\r\n                        <div class=\"card-info d-flex bg-light mb-4 align-items-center\">\r\n                            <div class=\"for-icon\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 3763, "\"", 3781, 1);
#nullable restore
#line 88 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
WriteAttributeValue("", 3771, card.Icon, 3771, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                            <div class=\"for-text ms-4\">\r\n                                <strong>");
#nullable restore
#line 91 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                                   Write(card.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <br>\r\n                                <small>");
#nullable restore
#line 92 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                                  Write(card.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 96 "C:\Users\M S I\source\repos\Sailor\Sailor\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Sailor.Service.LayoutService layout { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
