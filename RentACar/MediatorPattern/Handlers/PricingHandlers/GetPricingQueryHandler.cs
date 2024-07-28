using MediatR;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using RentACar.DAL;
using RentACar.MediatorPattern.Queries.PricingQueries;
using RentACar.MediatorPattern.Results.PricingResults;

namespace RentACar.MediatorPattern.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly Context _context;

        public GetPricingQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            return await _context.Pricings.Select(x => new GetPricingQueryResult
            {
                Name = x.Name,
                PricingID = x.PricingID
            }).ToListAsync();
        }
    }
}
