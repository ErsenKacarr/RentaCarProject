using RentACar.DAL;

namespace RentACar.CQRS.Results.CarResults
{
    public class GetCarWithPricingQueryResult
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public int Door { get; set; }
        public string Fuel { get; set; }
        public string BıgImageUrl { get; set; }
        public string BrandName { get; set; }
        public string PricingName { get; set; }
        public decimal PricingAmount { get; set; }
    }
}
