using MediatR;
using NuGet.Protocol.Plugins;
using RentACar.DAL;
using RentACar.MediatorPattern.Queries.LocationQueries;
using RentACar.MediatorPattern.Results.LocationResults;

namespace RentACar.MediatorPattern.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly Context _context;

        public GetLocationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Locations.FindAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                LocationID = values.LocationID,
                LocationName = values.LocationName
            };
        }
    }
}
