using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager SubAboutManager = new SubAboutManager(new EFSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = SubAboutManager.GetList();
            return View(values);
        }
    }
}
