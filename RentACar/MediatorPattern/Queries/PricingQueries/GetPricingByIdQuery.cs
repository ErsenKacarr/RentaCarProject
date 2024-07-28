using MediatR;
using RentACar.MediatorPattern.Results.PricingResults;

namespace RentACar.MediatorPattern.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
