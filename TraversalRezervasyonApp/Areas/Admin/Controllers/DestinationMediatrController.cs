using MediatR;
using Microsoft.AspNetCore.Mvc;
using TraversalRezervasyonApp.CQRS.Queries.GuideQueries;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    public class DestinationMediatrController : Controller
    {
        private readonly IMediator _mediatr;

        public DestinationMediatrController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public async  Task<IActionResult> Index()
        {
            var values = await _mediatr.Send(new GetAllGuideQuery());
            return View(values);
        }
    }
}
