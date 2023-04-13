using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TRAVEL.CQRS.Commands.GuideCommandas;
using TRAVEL.CQRS.Queries.GuideQueries;

namespace TRAVEL.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public DestinationMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult>GetGuides(int id)
        {
            var values = await _mediator.Send(new GetGuideByIDQuery(id));
            
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
