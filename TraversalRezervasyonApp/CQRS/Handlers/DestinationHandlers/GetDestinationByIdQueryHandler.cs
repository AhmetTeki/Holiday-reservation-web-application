using DataAccessLayer.Concrete;
using TraversalRezervasyonApp.CQRS.Queries.DestinationQueries;
using TraversalRezervasyonApp.CQRS.Results.DestinationResults;

namespace TraversalRezervasyonApp.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,

            };
        }
    }
}
