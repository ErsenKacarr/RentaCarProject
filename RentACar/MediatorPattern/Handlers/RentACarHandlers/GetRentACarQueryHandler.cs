using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACar.DAL;
using RentACar.MediatorPattern.Queries.RentACarQueries;
using RentACar.MediatorPattern.Results.RentACarResults;

namespace RentACar.MediatorPattern.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly Context _context;

        public GetRentACarQueryHandler(Context context, IMediator mediator)
        {
            _context = context;
        }


        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.RentACars.Include(x => x.Car).Include(x => x.Location).Where(x => x.LocationID == request.LocationID).ToListAsync();
            return values.Select(x => new GetRentACarQueryResult
            {
               CarId = x.CarID,
               Brand = x.Brand,
               Model = x.Model,
               Km = x.Km,
               Fuel = x.Fuel,
               Transmission = x.Transmission,
               Price = x.Price,
               Luggage = x.Luggage,
               Seat = x.Seat,
               CoverImageUrl = x.CoverImageUrl

            }).ToList();
        }
    }
}
