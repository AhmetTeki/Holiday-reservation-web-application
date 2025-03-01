using DataAccessLayer.Concrete;
using TraversalRezervasyonApp.CQRS.Commands.DestinationCommands;

namespace TraversalRezervasyonApp.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDesitnationCommandHandler
    {
        private readonly Context _context;

        public RemoveDesitnationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
