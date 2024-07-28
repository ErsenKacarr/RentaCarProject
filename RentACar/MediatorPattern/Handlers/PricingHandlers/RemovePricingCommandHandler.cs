using MediatR;
using RentACar.DAL;
using RentACar.MediatorPattern.Commands.PricingCommands;

namespace RentACar.MediatorPattern.Handlers.PricingHandlers
{
    public class RemovePricingCommandHandler : IRequestHandler<RemovePricingCommand>
    {
        private readonly Context _context;

        public RemovePricingCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemovePricingCommand request, CancellationToken cancellationToken)
        {
           var values = _context.Pricings.Find(request.PricingID);
            _context.Pricings.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
