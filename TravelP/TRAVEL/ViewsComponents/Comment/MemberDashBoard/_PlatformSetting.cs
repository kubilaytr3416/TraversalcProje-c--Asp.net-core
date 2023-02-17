using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.Comment.MemberDashBoard
{
    public class _PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
