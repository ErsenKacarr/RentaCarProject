using MediatR;
using RentACar.MediatorPattern.Results.LocationResults;

namespace RentACar.MediatorPattern.Queries.LocationQueries
{
    public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
    {
        public int Id { get; set; }

        public GetLocationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
