using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.MemberLayout
{
    public class _MemberLayoutHeaderContent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
