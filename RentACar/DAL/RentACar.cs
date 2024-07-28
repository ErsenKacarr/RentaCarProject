namespace RentACar.DAL
{
    public class RentACar
    {
        public int RentACarId { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public bool Available { get; set; }
        public string Price { get; set; }
        public int Km { get; set; }
        public string Fuel { get; set; }
        public string Transmission { get; set; }
        public byte Luggage { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public byte Seat { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
