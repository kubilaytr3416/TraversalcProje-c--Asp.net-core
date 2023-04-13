using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TRAVEL.Controllers
{
    [AllowAnonymous]

    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = destinationManager.GetList();

            return View(values);
        }
        //[HttpGet]

        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.Id = id;
            ViewBag.destID = id;
            var value =await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = value.Id;
            var values = destinationManager.GetDestinationWithGuide(id);
            return View(values);
        }

        //[HttpPost]
        //public IActionResult DestinationDetails(Destination p)
        //{
        //    return View();
        //}
    }
}
