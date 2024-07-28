using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACar.DAL;
using RentACar.MediatorPattern.Queries.CarFeatureDetail;
using RentACar.MediatorPattern.Results.CarFeatureResults;

namespace RentACar.MediatorPattern.Handlers.CarFeatureDetailHandlers
{
    public class GetCarFeatureDetailQueryHandler : IRequestHandler<GetCarFeatureDetailQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly Context _context;

        public GetCarFeatureDetailQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureDetailQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars.Select(x => new GetCarFeatureByCarIdQueryResult
            {
                CarID = x.CarID,
                Model = x.Model,
                Km = x.Km,
                Luggage = x.Luggage,
                Seat = x.Seat,
                CoverImageUrl = x.CoverImageUrl,
                LocationID = x.LocationID,
                Fuel = x.Fuel,
                Transmission = x.Transmission              
            }).ToListAsync();
        }
    }
}
