using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACar.DAL;
using RentACar.MediatorPattern.Queries.LocationQueries;
using RentACar.MediatorPattern.Queries.RentACarQueries;
using RentACar.MediatorPattern.Results.LocationResults;
using RentACar.MediatorPattern.Results.RentACarResults;

namespace RentACar.MediatorPattern.Handlers.LocationHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly Context _context;

        public GetRentACarQueryHandler(Context context, IMediator mediator)
        {
            _context = context;
        }

        public Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var i = _context.RentACars;
            var values = _context.RentACars
               .Include(x => x.Car)
               .ThenInclude(b => b.Brand)
               .Where(x => x.LocationID == request.LocationID && x.Available == true)
               .ToList();


            var result = values.Select(x => new GetRentACarQueryResult
            {
                CarId = x.CarID,
                Brand = x.Car.Brand.Name,
                Model = x.Car.Model,
                CoverImageUrl = x.Car.CoverImageUrl
            }).ToList();

            return Task.FromResult(result);
        }
    }
}
