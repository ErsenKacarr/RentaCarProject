using MediatR;
using RentACar.DAL;
using RentACar.MediatorPattern.Queries.PricingQueries;
using RentACar.MediatorPattern.Results.PricingResults;

namespace RentACar.MediatorPattern.Handlers.PricingHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly Context _context;

        public GetPricingByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Pricings.FindAsync(request.Id);
            return new GetPricingByIdQueryResult
            {
                PricingID = values.PricingID,
                Name = values.Name
            };
        }
    }
}
