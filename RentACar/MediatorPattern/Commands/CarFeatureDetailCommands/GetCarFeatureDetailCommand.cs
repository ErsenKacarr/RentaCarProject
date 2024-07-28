using MediatR;

namespace RentACar.MediatorPattern.Commands.CarFeatureDetailCommands
{
    public class GetCarFeatureDetailCommand : IRequest
    {
        public int CarID { get; set; }
    }
}
