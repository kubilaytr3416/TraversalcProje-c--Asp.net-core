#pragma checksum "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d74e2d33a221cc0fb8de1ea3240ebf0aa4b61a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d74e2d33a221cc0fb8de1ea3240ebf0aa4b61a4", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count= 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    img{
        border-radius:50%;
    }
</style>
<h1>Rehber Listesi</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>GÖRSEL</th>
        <th>AD SOYAD</th>
        <th>AÇIKLAMA</th>
        <th>DURUM</th>
        <th>DÜZENLE</th>
    </tr>
");
#nullable restore
#line 23 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 27 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src =\"", 577, "\"", 595, 1);
#nullable restore
#line 28 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 584, item.Image, 584, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"100\" /></td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           \r\n");
#nullable restore
#line 32 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
              
                if(item.Status==true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 817, "\"", 864, 2);
            WriteAttributeValue("", 824, "/Admin/Guide/ChangeToFalse/", 824, 27, true);
#nullable restore
#line 35 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 851, item.GuideID, 851, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Pasif Yap</a></td>\r\n");
#nullable restore
#line 36 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1052, 2);
            WriteAttributeValue("", 1013, "/Admin/Guide/ChangeToTrue/", 1013, 26, true);
#nullable restore
#line 40 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1039, item.GuideID, 1039, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Aktif Yap</a></td>                    \r\n");
#nullable restore
#line 41 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a href=\"/Admin/Guide/EditGuide/\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n\r\n        </tr>\n");
#nullable restore
#line 46 "C:\Users\KUBİLAY TAŞGIN\Desktop\TravelP\TRAVEL\Areas\Admin\Views\Guide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Guide/AddGuide\"class=\"btn btn-outline-primary\">Yeni Rehber Girişi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
