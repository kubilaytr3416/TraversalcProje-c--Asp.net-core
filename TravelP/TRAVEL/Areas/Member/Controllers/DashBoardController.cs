using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashBoardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashBoardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult>Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.User  = values.Name  +""+  values.Surname;
            @ViewBag.UserImage = values.ImageUrl;
            return View();
        }
    }
}
