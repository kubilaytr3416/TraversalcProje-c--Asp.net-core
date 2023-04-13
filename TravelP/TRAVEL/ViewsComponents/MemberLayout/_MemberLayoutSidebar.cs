using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.MemberLayout
{
    public class _MemberLayoutSidebar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
