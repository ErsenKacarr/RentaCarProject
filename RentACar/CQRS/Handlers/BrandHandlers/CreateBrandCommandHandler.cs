using RentACar.CQRS.Commands.BrandCommands;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly Context _context;

        public CreateBrandCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateBrandCommand command)
        {
            _context.Brands.Add(new Brand
            {
                Name = command.Name
            });
            _context.SaveChanges();
        }
    }
}
