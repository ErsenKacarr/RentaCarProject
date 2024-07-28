using MediatR;

namespace RentACar.MediatorPattern.Commands.LocationCommands
{
    public class CreateLocationCommand :IRequest
    {
        public string LocationName { get; set; }
    }
}
