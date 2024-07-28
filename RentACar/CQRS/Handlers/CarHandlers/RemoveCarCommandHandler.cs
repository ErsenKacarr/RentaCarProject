using RentACar.CQRS.Commands.CarCommands;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveCarCommand command)
        {
            var values = _context.Cars.Find(command.Id);
            _context.Cars.Remove(values);
            _context.SaveChanges();
        }
    }
}
