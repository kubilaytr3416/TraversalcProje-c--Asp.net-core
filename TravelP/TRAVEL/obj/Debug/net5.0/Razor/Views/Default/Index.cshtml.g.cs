#pragma checksum "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef5df6e892964dbfef169cf849dda6fe3e99bd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef5df6e892964dbfef169cf849dda6fe3e99bd8", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c88d2bcdb0d3f97af79bb7a8191a26b0685618", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_SliderPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_PopularDestinations"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_Statistics"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_Feature"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_SubAbout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_Testimonial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
