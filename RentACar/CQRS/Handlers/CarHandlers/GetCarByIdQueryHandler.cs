using RentACar.CQRS.Queries.CarQueries;
using RentACar.CQRS.Results.CarResults;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly Context _context;

        public GetCarByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetCarByIdQueryResult Handle(GetCarByIdQuery query)
        {
            var values = _context.Cars.Find(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID = values.BrandID,
                BıgImageUrl = values.BıgImageUrl,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,
                CarID = values.CarID,
                Transmission = values.Transmission,
                Seat = values.Seat,
                Model = values.Model,
                Km = values.Km,
                Luggage = values.Luggage,
            };
        }
    }
}
