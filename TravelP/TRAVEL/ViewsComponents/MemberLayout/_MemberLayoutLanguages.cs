using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.MemberLayout
{
    public class _MemberLayoutLanguages:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
