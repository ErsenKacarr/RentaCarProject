using RentACar.CQRS.Results.CarResults;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.CarHandlers
{
    public class GetCarWithPricingQueryHandler
    {
        private readonly Context _context;

        public GetCarWithPricingQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCarWithPricingQueryResult> Handle()
        {
            var values = _context.CarPricings.Select(x => new GetCarWithPricingQueryResult
            {
               CarID = x.CarID,
               Model = x.Car.Model,
               CoverImageUrl = x.Car.CoverImageUrl,
               BrandName = x.Car.Brand.Name,
               PricingName = x.Pricing.Name,
               PricingAmount = x.Amount,
               Km = x.Car.Km,
               Luggage = x.Car.Luggage        
            }).ToList();
            return values;
        }
    }
}
