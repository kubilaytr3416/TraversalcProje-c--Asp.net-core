#pragma checksum "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Statistics\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8dae4f01e9a9341d638fe55d0bdebf63dac3aba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Statistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Statistics/Default.cshtml")]
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
#line 1 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using TRAVEL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using TRAVEL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8dae4f01e9a9341d638fe55d0bdebf63dac3aba", @"/Views/Shared/Components/_Statistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d51e2241f6c632fb3ed83d0bd3cc5ea03b05d56", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Statistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"w3l-stats py-5\" id=\"stats\">\r\n    <div class=\"gallery-inner container py-lg-0 py-3\">\r\n        <div class=\"row stats-con pb-lg-3\">\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid\">\r\n                <p class=\"counter\">");
#nullable restore
#line 5 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Statistics\Default.cshtml"
                              Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Rotalar</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid1\">\r\n                <p class=\"counter\">");
#nullable restore
#line 9 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Statistics\Default.cshtml"
                              Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Tur Rehberleri</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid mt-lg-0 mt-5\">\r\n                <p class=\"counter\">");
#nullable restore
#line 13 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Views\Shared\Components\_Statistics\Default.cshtml"
                              Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <h4>Mutlu Müşteriler </h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid2 mt-lg-0 mt-5"">
                <p class=""counter"">25</p>
                <h4>Ödüller</h4>
            </div>
        </div>
    </div>
</section>
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
