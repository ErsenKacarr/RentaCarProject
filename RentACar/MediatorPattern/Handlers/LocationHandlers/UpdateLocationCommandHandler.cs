using MediatR;
using NuGet.Protocol.Plugins;
using RentACar.DAL;
using RentACar.MediatorPattern.Commands.LocationCommands;

namespace RentACar.MediatorPattern.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly Context _context;

        public UpdateLocationCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Locations.FindAsync(request.LocationID);
            values.LocationName = request.LocationName;
            await _context.SaveChangesAsync();
        }
    }
}
