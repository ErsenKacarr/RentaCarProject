using RentACar.CQRS.Results.CarResults;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly Context _context;

        public GetCarQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCarQueryResult> Handle()
        {
            var values = _context.Cars.Select(x => new GetCarQueryResult
            {
                BrandID = x.BrandID,
                BıgImageUrl = x.BıgImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission,
                Price = x.Price
            }).ToList();
            return values;
        }
    }
}
