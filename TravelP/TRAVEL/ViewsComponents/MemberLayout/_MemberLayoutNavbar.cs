using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.MemberLayout
{
    public class _MemberLayoutNavbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }

    }
}
