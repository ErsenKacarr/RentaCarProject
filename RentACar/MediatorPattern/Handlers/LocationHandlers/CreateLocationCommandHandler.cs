using MediatR;
using NuGet.Protocol.Plugins;
using RentACar.DAL;
using RentACar.MediatorPattern.Commands.LocationCommands;

namespace RentACar.MediatorPattern.Handlers.LocationHandlers
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly Context _context;

        public CreateLocationCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _context.Locations.AddAsync(new Location
            {
                LocationName = request.LocationName
            });
            await _context.SaveChangesAsync();
        }
    }
}
