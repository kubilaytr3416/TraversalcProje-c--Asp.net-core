#pragma checksum "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3729d37775af5ddb1fc15efd97910edb07fb7fe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\_ViewImports.cshtml"
using TRAVEL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\_ViewImports.cshtml"
using TRAVEL.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3729d37775af5ddb1fc15efd97910edb07fb7fe1", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebed0dd6fa3b7448e35d29474b0a347f882cb8a4", @"/Areas/Admin/Views/Destination/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>TUR ROTALARI</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Fiyat</th>
        <th>Image</th>
        <th>Kapasite</th>
        <th>Sitede Gör</th>
        <th>Sil</th>
        <th>Güncelle</th>
    
    </tr>
");
#nullable restore
#line 20 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 23 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 741, 2);
            WriteAttributeValue("", 690, "/Destination/DestinationDetails/", 690, 32, true);
#nullable restore
#line 28 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 722, item.DestinationID, 722, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 811, "\"", 874, 2);
            WriteAttributeValue("", 818, "/Admin/Destination/DeleteDestination/", 818, 37, true);
#nullable restore
#line 29 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 855, item.DestinationID, 855, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 939, "\"", 1002, 2);
            WriteAttributeValue("", 946, "/Admin/Destination/UpdateDestination/", 946, 37, true);
#nullable restore
#line 30 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 983, item.DestinationID, 983, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\n");
#nullable restore
#line 32 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Destination\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/Destination/AddDestination\" class=\"btn btn-outline-primary\"> Yeni Tur Rotası</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
