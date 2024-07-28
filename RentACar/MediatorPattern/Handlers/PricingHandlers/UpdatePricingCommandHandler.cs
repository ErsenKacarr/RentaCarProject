using MediatR;
using RentACar.DAL;
using RentACar.MediatorPattern.Commands.PricingCommands;

namespace RentACar.MediatorPattern.Handlers.PricingHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly Context _context;

        public UpdatePricingCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Pricings.FindAsync(request.PricingID);
            values.Name = request.Name;
            await _context.SaveChangesAsync();
        }
    }
}
