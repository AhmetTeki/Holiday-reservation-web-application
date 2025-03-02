using MediatR;
using TraversalRezervasyonApp.CQRS.Results.GuideResult;

namespace TraversalRezervasyonApp.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery: IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
