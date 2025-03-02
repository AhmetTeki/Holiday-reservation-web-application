
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using TraversalRezervasyonApp.CQRS.Commands.GuideCommand;

namespace TraversalRezervasyonApp.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Description = request.Description,
                Name = request.Name,
                Status = true   
            });
          await _context.SaveChangesAsync();
        }
    }
}
