using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalRezervasyonApp.CQRS.Commands.DestinationCommands;
using TraversalRezervasyonApp.CQRS.Handlers.DestinationHandlers;
using TraversalRezervasyonApp.CQRS.Queries.DestinationQueries;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _handler;
        private readonly GetDestinationByIdQueryHandler _byIdHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDesitnationCommandHandler _removeDestination;
        private readonly UpdateDestinationCommandHandler _updateDestination;

        public DestinationCQRSController(GetAllDestinationQueryHandler handler, GetDestinationByIdQueryHandler byIdHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDesitnationCommandHandler removeDestination, UpdateDestinationCommandHandler updateDestination)
        {
            _handler = handler;
            _byIdHandler = byIdHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestination = removeDestination;
            _updateDestination = updateDestination;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _byIdHandler.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestination.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            _removeDestination.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }
    }
}
