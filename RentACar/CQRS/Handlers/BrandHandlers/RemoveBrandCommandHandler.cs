using RentACar.CQRS.Commands.BrandCommands;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly Context _context;

        public RemoveBrandCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveBrandCommand command)
        {
            var values = _context.Brands.Find(command.Id);
            _context.Brands.Remove(values);
            _context.SaveChanges();
        }
    }
}
