using RentACar.CQRS.Results.CarResults;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly Context _context;

        public GetCarWithBrandQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _context.Cars.Select(x => new GetCarWithBrandQueryResult
            {
                BrandName = x.Brand.Name,
                BıgImageUrl = x.BıgImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission,
                Price = x.Price,
            }).ToList();
            return values;
        }
    }
}
