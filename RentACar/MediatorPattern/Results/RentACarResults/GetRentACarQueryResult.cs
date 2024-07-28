namespace RentACar.MediatorPattern.Results.RentACarResults
{
    public class GetRentACarQueryResult
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }
        public string Fuel { get; set; }
        public string Transmission { get; set; }
        public string Price { get; set; }
        public byte Luggage { get; set; }
        public byte Seat { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
