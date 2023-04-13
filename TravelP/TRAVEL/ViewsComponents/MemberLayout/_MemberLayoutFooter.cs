using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.MemberLayout
{
    public class _MemberLayoutFooter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
