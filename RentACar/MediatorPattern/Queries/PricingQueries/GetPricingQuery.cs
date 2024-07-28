using MediatR;
using RentACar.MediatorPattern.Results.PricingResults;

namespace RentACar.MediatorPattern.Queries.PricingQueries
{
    public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
    {

    }
}
