using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.ViewsComponents.Comment.MemberDashBoard
{
    public class _Profileinformation:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _Profileinformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult>InvokeAsync()
        {   
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = values.Name + "" + values.Surname;
                ViewBag.MemberPhone = values.PhoneNumber;
                ViewBag.MemberMail = values.Email;
                return View();   
        }
    }
}
