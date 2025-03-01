using DataAccessLayer.Concrete;
using TraversalRezervasyonApp.CQRS.Commands.DestinationCommands;

namespace TraversalRezervasyonApp.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationId);
            values.City = command.City;
            values.DayNight = command.DayNight;
           
            _context.SaveChanges();
        }
    }
}
