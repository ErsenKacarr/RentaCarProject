using MediatR;

namespace RentACar.MediatorPattern.Commands.PricingCommands
{
    public class CreatePricingCommand : IRequest
    {
        public string Name { get; set; }
    }
}
