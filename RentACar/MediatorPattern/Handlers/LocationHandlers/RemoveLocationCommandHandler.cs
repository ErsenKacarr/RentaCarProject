using MediatR;
using NuGet.Protocol.Plugins;
using RentACar.DAL;
using RentACar.MediatorPattern.Commands.LocationCommands;

namespace RentACar.MediatorPattern.Handlers.LocationHandlers
{
    public class RemoveLocationCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly Context _context;

        public RemoveLocationCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Locations.Find(request.LocationId);
            _context.Locations.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
