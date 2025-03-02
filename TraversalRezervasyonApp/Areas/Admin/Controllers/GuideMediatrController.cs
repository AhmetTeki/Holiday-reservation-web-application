using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalRezervasyonApp.CQRS.Commands.GuideCommand;
using TraversalRezervasyonApp.CQRS.Queries.GuideQueries;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideMediatrController : Controller
    {
        private readonly IMediator _mediatr;

        public GuideMediatrController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public async  Task<IActionResult> Index()
        {
            var values = await _mediatr.Send(new GetAllGuideQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetGuides(int id) 
        {
            var values = await _mediatr.Send(new GetGuideByIdQuery(id));
            return View(values);
        }
        [HttpGet]
        public  IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand command)
        {
            await _mediatr.Send(command);
            return RedirectToAction("Index");
        }
    }
}
