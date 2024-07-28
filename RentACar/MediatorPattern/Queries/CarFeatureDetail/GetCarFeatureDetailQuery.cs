using MediatR;
using RentACar.MediatorPattern.Results.CarFeatureResults;
using RentACar.MediatorPattern.Results.RentACarResults;

namespace RentACar.MediatorPattern.Queries.CarFeatureDetail
{
    public class GetCarFeatureDetailQuery : IRequest<List<GetCarFeatureByCarIdQueryResult>>
    {
        public int CarID { get; set; }
    }
}
