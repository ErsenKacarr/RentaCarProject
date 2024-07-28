using RentACar.CQRS.Queries.BrandQueries;
using RentACar.CQRS.Results.BrandResults;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly Context _context;

        public GetBrandByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var values = _context.Brands.Find(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandID = values.BrandID,
                Name = values.Name
            };
        }
    }
}
