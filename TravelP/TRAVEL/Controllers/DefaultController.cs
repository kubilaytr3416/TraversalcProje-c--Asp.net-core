using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
