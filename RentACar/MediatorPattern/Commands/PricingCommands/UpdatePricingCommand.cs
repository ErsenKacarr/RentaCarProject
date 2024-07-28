using MediatR;

namespace RentACar.MediatorPattern.Commands.PricingCommands
{
    public class UpdatePricingCommand : IRequest
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
    }
}
