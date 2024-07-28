using MediatR;
using NuGet.Protocol.Plugins;
using RentACar.DAL;
using RentACar.MediatorPattern.Commands.PricingCommands;

namespace RentACar.MediatorPattern.Handlers.PricingHandlers
{
    public class CreatePrincingQueryHandler : IRequestHandler<CreatePricingCommand>
    {
        private readonly Context _context;

        public CreatePrincingQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            await _context.Pricings.AddAsync(new Pricing
            {
                Name = request.Name
            });
            await _context.SaveChangesAsync();
        }
    }
}
