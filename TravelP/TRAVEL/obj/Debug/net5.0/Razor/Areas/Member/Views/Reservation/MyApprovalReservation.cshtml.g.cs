#pragma checksum "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a026587f6e3129a31df4478ad2a9cab2898ef67f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyApprovalReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
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
#line 1 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\_ViewImports.cshtml"
using TRAVEL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\_ViewImports.cshtml"
using TRAVEL.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a026587f6e3129a31df4478ad2a9cab2898ef67f", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebed0dd6fa3b7448e35d29474b0a347f882cb8a4", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyApprovalReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
  
    ViewData["Title"] = "MyApprovalReservation";
	Layout = "~/Views/Shared/LayoutPartical/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-12"">
		<div class=""card"">
			<div class=""card-header"">
				<h4 class=""card-title"">Onay Beklemeyen Rezervasyonlar</h4>
				<a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
				<div class=""heading-elements"">
					<ul class=""list-inline mb-0"">
						<li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
						<li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
						<li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
						<li><a data-action=""close""><i class=""ft-x""></i></a></li>
					</ul>
				</div>
			</div>
			<div class=""card-content collapse show"">
				<div class=""card-body"">
					<p class=""card-text"">Web Sitemiz Traversal Üzerinden yapmış olduğuz onay bekleyene rezervasyon listenize aşaıdan erişebilirsiniz.Rehberlerimiz ve Diğer çalışanlarımız en kısa sürede Sizlere Dönüş yapacaktır. </p>
					<div class=""table-responsive"">
						<table class=""table"">
							<thead>
								<tr");
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<th>#</th>\r\n\t\t\t\t\t\t\t\t\t<th>lOKASYON</th>\r\n\t\t\t\t\t\t\t\t\t<th>Kişi Sayısı</th>\r\n\t\t\t\t\t\t\t\t\t<th>Rezervasyon Tarihi</th>\r\n\t\t\t\t\t\t\t\t\t<th>Durum</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</thead>\r\n\t\t\t\t\t\t\t<tbody>\r\n");
#nullable restore
#line 38 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                 foreach (var item in Model)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 41 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                       Write(item.ReservationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 42 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                       Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 43 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                       Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 44 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                       Write(item.ReservastionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 45 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 49 "C:\Users\AgöBilişim\Desktop\TravelP\TRAVEL\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
