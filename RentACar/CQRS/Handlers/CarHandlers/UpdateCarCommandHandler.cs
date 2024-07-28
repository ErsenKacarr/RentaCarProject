using RentACar.CQRS.Commands.CarCommands;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly Context _context;

        public UpdateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateCarCommand command)
        {
            var value = _context.Cars.Find(command.CarID);
            value.Fuel = command.Fuel;
            value.Transmission = command.Transmission;
            value.BıgImageUrl = command.BıgImageUrl;
            value.BrandID = command.BrandId;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Km = command.Km;
            value.Luggage = command.Luggage;
            value.Model = command.Model;
            value.Seat = command.Seat;
            _context.SaveChanges();
        }
    }
}
