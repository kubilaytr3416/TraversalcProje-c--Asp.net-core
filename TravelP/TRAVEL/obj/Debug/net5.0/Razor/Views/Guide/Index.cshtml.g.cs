#pragma checksum "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e348c1beceae0787bafead036c5e0706716ef107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guide_Index), @"mvc.1.0.view", @"/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using TRAVEL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using TRAVEL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using TRAVEL.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using TRAVEL.CQRS.Commands.GuideCommandas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e348c1beceae0787bafead036c5e0706716ef107", @"/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c88d2bcdb0d3f97af79bb7a8191a26b0685618", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""w3l-team"" id=""team"">
    <div class=""team-block py-5"">
        <div class=""container py-lg-5"">
            <div class=""title-content text-center mb-lg-3 mb-4"">
                <h6 class=""sub-title"">Ekip Arkadaşlarımız</h6>
                <h3 class=""hny-title"">Rehberlerimizle Tanışın</h3>
            </div>
            <div class=""row"">
");
#nullable restore
#line 14 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Guide\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-6 mt-lg-5 mt-4\">\r\n                        <div class=\"box16\">\r\n                            <a href=\"#url\"><img");
            BeginWriteAttribute("src", " src=\"", 714, "\"", 731, 1);
#nullable restore
#line 18 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Guide\Index.cshtml"
WriteAttributeValue("", 720, item.Image, 720, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 732, "\"", 738, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" /></a>\r\n                            <div class=\"box-content\">\r\n                                <h3 class=\"title\"><a href=\"#url\">");
#nullable restore
#line 20 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Guide\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <span class=\"post\">");
#nullable restore
#line 21 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Guide\Index.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <ul class=""social"">
                                    <li>
                                        <a href=""#"" class=""facebook"">
                                            <span class=""fa fa-facebook-f""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""twitter"">
                                            <span class=""fa fa-twitter""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 37 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Guide\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
