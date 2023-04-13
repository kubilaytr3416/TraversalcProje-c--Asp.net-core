using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            this._contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values =_contactUsService.GetListContactUsByTrue();
            return View(values);
        }
    }
}
