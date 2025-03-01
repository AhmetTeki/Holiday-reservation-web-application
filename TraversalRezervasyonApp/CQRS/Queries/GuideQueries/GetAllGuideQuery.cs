using MediatR;
using TraversalRezervasyonApp.CQRS.Results.GuideResult;

namespace TraversalRezervasyonApp.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery: IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
