using MediatR;

namespace RentACar.MediatorPattern.Commands.LocationCommands
{
    public class UpdateLocationCommand : IRequest
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
    }
}
