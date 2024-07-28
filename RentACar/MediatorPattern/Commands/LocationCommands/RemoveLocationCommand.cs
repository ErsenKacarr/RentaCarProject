using MediatR;

namespace RentACar.MediatorPattern.Commands.LocationCommands
{
    public class RemoveLocationCommand : IRequest
    {
        public int LocationId { get; set; }

        public RemoveLocationCommand(int locationId)
        {
            LocationId = locationId;
        }
    }
}
