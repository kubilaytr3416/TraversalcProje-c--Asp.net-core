using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.Default
{
    public class _SliderPartial:ViewComponent
    {      
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
