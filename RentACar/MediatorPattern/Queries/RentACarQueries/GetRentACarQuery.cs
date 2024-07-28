using MediatR;
using RentACar.MediatorPattern.Results.RentACarResults;

namespace RentACar.MediatorPattern.Queries.RentACarQueries
{
    public class GetRentACarQuery : IRequest<List<GetRentACarQueryResult>>
    {
        public int LocationID { get; set; }
        public bool Available { get; set; }
    }
}
