using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalRezervasyonApp.CQRS.Queries.DestinationQueries;
using TraversalRezervasyonApp.CQRS.Results.DestinationResults;

namespace TraversalRezervasyonApp.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle() 
        {
            var values=_context.Destinations.Select(x=>new GetAllDestinationQueryResult
            {
                capacity=x.Capacity,
                city=x.City,
                daynight=x.DayNight,
                id=x.DestinationID,
                price=x.Price,
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
