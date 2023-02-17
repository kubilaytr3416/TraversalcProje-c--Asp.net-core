using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.AdminDashBoard
{
    public class _DashBoardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

