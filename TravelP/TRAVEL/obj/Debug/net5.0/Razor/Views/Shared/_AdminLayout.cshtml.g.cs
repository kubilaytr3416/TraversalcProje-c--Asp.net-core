#pragma checksum "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b7267a38504b58a9d89b626e9d96ace6e62f1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b7267a38504b58a9d89b626e9d96ace6e62f1c", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c88d2bcdb0d3f97af79bb7a8191a26b0685618", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>
<!-- beautify ignore:start -->
<html lang=""en""
      class=""light-style layout-menu-fixed""
      dir=""ltr""
      data-theme=""theme-default""
      data-assets-path=""~/sneat-1.0.0/assets/""
      data-template=""vertical-menu-template-free"">
");
#nullable restore
#line 14 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialHeader.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22b7267a38504b58a9d89b626e9d96ace6e62f1c4611", async() => {
                WriteLiteral(@"
    <!-- Layout wrapper -->
    <div class=""layout-wrapper layout-content-navbar"">
        <div class=""layout-container"">
            <!-- Menu -->
            <aside id=""layout-menu"" class=""layout-menu menu-vertical menu bg-menu-theme"">
                <div class=""app-brand demo"">
                    <a href=""index.html"" class=""app-brand-link"">

                        ");
#nullable restore
#line 24 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
                   Write(await Html.PartialAsync("/Views/Admin/PartialAppBrandDemo.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <span class=""app-brand-text demo menu-text fw-bolder ms-2"">Sneat</span>
                    </a>

                    <a href=""javascript:void(0);"" class=""layout-menu-toggle menu-link text-large ms-auto d-block d-xl-none"">
                        <i class=""bx bx-chevron-left bx-sm align-middle""></i>
                    </a>
                </div>

                <div class=""menu-inner-shadow""></div>

                ");
#nullable restore
#line 35 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/PartialSideBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </aside>\r\n            <!-- / Menu -->\r\n            <!-- Layout container -->\r\n            <div class=\"layout-page\">\r\n                <!-- Navbar -->\r\n                ");
#nullable restore
#line 41 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/PartialNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <!-- / Navbar -->
                <!-- Content wrapper -->
                <div class=""content-wrapper"">
                    <!-- Content -->
                    <div class=""container-xxl flex-grow-1 container-p-y"">
                        <!-- Basic Layout -->
                        ");
#nullable restore
#line 48 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <!-- / Content -->\r\n                    <!-- Footer -->\r\n                    ");
#nullable restore
#line 52 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
               Write(await Html.PartialAsync("/Views/Admin/Footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <!-- / Footer -->

                    <div class=""content-backdrop fade""></div>
                </div>
                <!-- Content wrapper -->
            </div>
            <!-- / Layout page -->
        </div>

        <!-- Overlay -->
        <div class=""layout-overlay layout-menu-toggle""></div>
    </div>
    <!-- / Layout wrapper -->

    <!-- Core JS -->
    <!-- build:js assets/vendor/js/core.js -->
    ");
#nullable restore
#line 69 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
