#pragma checksum "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Profileinformation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b343f172043d340ccdf14f181d435845fbf1b905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Profileinformation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Profileinformation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b343f172043d340ccdf14f181d435845fbf1b905", @"/Views/Shared/Components/_Profileinformation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c88d2bcdb0d3f97af79bb7a8191a26b0685618", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Profileinformation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <div class=""row"">
                <div class=""col-md-8 d-flex align-items-center"">
                    <h6 class=""mb-0"">Profil Bilgileri</h6>
                </div>
                <div class=""col-md-4 text-end"">
                    <a href=""Member/Profile/Index/"">
                        <i class=""fas fa-user-edit text-secondary text-sm"" data-bs-toggle=""tooltip"" data-bs-placement=""top"" title=""Edit Profile""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""card-body p-3"">
            <p class=""text-sm"">
                Traversal Rezervasyon Üye Paneline HoşGeldiniz,sol tarafta bulunan  menüler üzerinden geçmiş rezervasyonlarınızı,aktif rezervasyonlarınızı,onaylanmayan rezervasyonlarınızı  ve iletişim detaylarını görebilirsiniz
            </p>
            <hr class=""horizontal gray-light my-4"">
            <ul class=""list-");
            WriteLiteral("group\">\r\n                <li class=\"list-group-item border-0 ps-0 pt-0 text-sm\"><strong class=\"text-dark\">Ad Soyad:</strong> &nbsp;");
#nullable restore
#line 21 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Profileinformation\Default.cshtml"
                                                                                                                     Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Telefon:</strong> &nbsp;");
#nullable restore
#line 22 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Profileinformation\Default.cshtml"
                                                                                                               Write(ViewBag.MemberPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Email:</strong> &nbsp; ");
#nullable restore
#line 23 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Profileinformation\Default.cshtml"
                                                                                                              Write(ViewBag.MemberMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li class=""list-group-item border-0 ps-0 text-sm""><strong class=""text-dark"">Konum:</strong> &nbsp; TR</li>
                <li class=""list-group-item border-0 ps-0 pb-0"">
                    <strong class=""text-dark text-sm"">Sosyal Medya:</strong> &nbsp;
                    <a class=""btn btn-facebook btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-facebook fa-lg""></i>
                    </a>
                    <a class=""btn btn-twitter btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-twitter fa-lg""></i>
                    </a>
                    <a class=""btn btn-instagram btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-instagram fa-lg""></i>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
