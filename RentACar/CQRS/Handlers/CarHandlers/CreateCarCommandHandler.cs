using RentACar.CQRS.Commands.CarCommands;
using RentACar.CQRS.Commands.BrandCommands;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly Context _context;

        public CreateCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateCarCommand command) 
        {
            _context.Cars.Add(new Car
            {
                BıgImageUrl = command.BıgImageUrl,
                Luggage = command.Luggage,
                Km = command.Km,
                Model = command.Model,
                Seat = command.Seat,
                Transmission = command.Transmission,
                CoverImageUrl = command.CoverImageUrl,
                BrandID = command.BrandId,
                Fuel = command.Fuel
            });
            _context.SaveChanges();
        }
    }
}
