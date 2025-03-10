﻿using DataAccessLayer.Concrete;
using MediatR;
using TraversalRezervasyonApp.CQRS.Queries.GuideQueries;
using TraversalRezervasyonApp.CQRS.Results.GuideResult;

namespace TraversalRezervasyonApp.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideID=values.GuideID,
                Description=values.Description,
                Name=values.Name,
            };
        }
    }
}
