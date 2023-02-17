using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.AdminDashBoard
{
    public class _AdminDashBoardHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
